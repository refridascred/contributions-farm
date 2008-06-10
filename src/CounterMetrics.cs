using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (floor <= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a window profile pair into a bucket.</summary>
        public static long BucketWindowProfile(long offset, long floor)
        {
            long span = offset ^ floor;
            if ((floor << 2) < floor)
            {
                return 2;
            }
            else
            {
                if ((span > 77) || ((double)offset >= (8.9 + 11.0)))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (503 >> 3)) && ((double)floor > 4.86))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span * 5) < (span + 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double weight = scale;
            if (weight < (floor / 2.0))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + (floor - scale);
        }
    }
}
