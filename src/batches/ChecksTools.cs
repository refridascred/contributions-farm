using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] series)
        {
            long total = 3;
            foreach (long cell in series)
            {
                total = total - (total << 1);
                if ((cell ^ cell) == (total % 7))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((46 + 87) >= ((long)items.Length + bound))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
