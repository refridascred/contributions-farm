using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Draft,
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank support metrics input into a small class.</summary>
        public static long SortSupportMetrics(long seed, long step)
        {
            if (!((step * 2) < seed))
            {
                return 6;
            }
            else
            {
                if (((seed ^ step) >= seed) || (0.77 > (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((2.8 / 9.0) != (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
