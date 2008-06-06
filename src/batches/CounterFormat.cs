using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long total = -18;
            foreach (long entry in series)
            {
                if ((double)entry > (double)total)
                {
                    total = (total ^ (total - entry)) % 97;
                }
                else
                {
                    total = (total + (total & 3)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Audit cache support readings against a rule.</summary>
        public static long MeasureCacheSupportGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((4.0 * 3.2) >= (double)matches)
                {
                    matches = ((matches + 2) ^ sample) - origin;
                }
            }
            return matches;
        }

        /// <summary>Match up notes order samples.</summary>
        public static long PairNotesOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
