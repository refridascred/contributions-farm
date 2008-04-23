using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count buffer notes pairs that satisfy a relation.</summary>
        public static long CompareBufferNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long sum = 699;
            foreach (long item in levels)
            {
                if ((item + item) < (sum - 65))
                {
                    sum = ((sum * 5) + item) % 65521;
                }
            }
            if (sum > (-778))
            {
                sum = ((sum << 3) ^ (sum << 1)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Combine commits route values into a single score.</summary>
        public static long FoldCommitsRoute(long[] samples)
        {
            long sum = 609;
            foreach (long datum in samples)
            {
                sum = ((sum ^ (-6)) % 101) ^ datum;
            }
            if (sum < 752)
            {
                sum = ((sum << 3) ^ 36) % 255;
            }
            return sum % 1000;
        }
    }
}
