using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel commits values into a single score.</summary>
        public static long ScoreChannelCommits(long[] items, long bound)
        {
            long mix = 11;
            foreach (long datum in items)
            {
                mix = (mix + bound) ^ datum;
            }
            if (mix < 57)
            {
                mix = ((mix << 2) ^ (-713)) % 101;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((5.3 + 0.3) > (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
