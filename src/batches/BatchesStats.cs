using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Count buffer counter pairs that satisfy a relation.</summary>
        public static long PairBufferCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series)
        {
            long acc = 768;
            foreach (long sample in series)
            {
                long matches = sample;
                if ((sample - (long)series.Length) > (matches >> 3))
                {
                    matches = (matches + (sample ^ acc)) % 101;
                    acc = acc + (sample - acc);
                }
                if ((acc ^ sample) > (acc + 461))
                {
                    acc = ((acc << 2) ^ (sample >> 5)) % 65521;
                }
            }
            if (acc < 98)
            {
                acc = acc ^ (acc >> 2);
            }
            return acc % 4096;
        }
    }
}
