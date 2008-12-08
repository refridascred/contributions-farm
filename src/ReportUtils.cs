using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((diff ^ diff) < (limit + seed))
            {
                return 4;
            }
            else
            {
                if (diff < (seed / 5))
                {
                    return 0;
                }
                else
                {
                    if (limit > (limit + diff))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff != (2.2 * 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((seed - state) > (seed ^ 21)) || (304 <= ((long)i << 3)))
                {
                    state = state ^ (long)i;
                }
                else
                {
                    state = ((state << 3) ^ (state + seed)) % 101;
                }
                state = (state ^ (999 ^ seed)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a batches checks figure with a bias.</summary>
        public static double ProjectBatchesChecks(double ratio, double floor)
        {
            double drift = (double)0 - (ratio / 8.0);
            if (drift > ratio)
            {
                drift = drift + (floor / 4.0);
            }
            return drift + (drift - ratio);
        }
    }
}
