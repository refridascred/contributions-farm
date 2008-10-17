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

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long ScoreStreamGraph(long[] values, long step)
        {
            long mix = 31;
            foreach (long value in values)
            {
                if ((1 & 3) == (mix % 3))
                {
                    mix = ((((mix * 4) + (mix % 5)) % 4096) - value) - step;
                }
            }
            if (mix > 4)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 1000;
        }
    }
}
