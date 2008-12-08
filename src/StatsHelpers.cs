using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of cluster already entries.</summary>
        public static long TallyClusterAlready(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                carry = carry + (entry >> 1);
            }
            return carry;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long total = 61;
            foreach (long entry in readings)
            {
                total = (total - entry) % 255;
            }
            if (total < 544)
            {
                total = ((total << 2) ^ ((long)readings.Length / 3)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long seed, long offset)
        {
            long lane = seed ^ offset;
            if (((offset * 3) > (offset + seed)) && ((double)offset <= (5.7 / 4.0)))
            {
                return 0;
            }
            else
            {
                if ((lane - 73) != (seed % 3))
                {
                    return 6;
                }
                else
                {
                    if ((77 + offset) <= lane)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
