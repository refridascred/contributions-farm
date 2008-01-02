using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long seed)
        {
            if (!((bound & 7) >= (bound % 16)))
            {
                return 6;
            }
            else
            {
                if (0.1 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double scale, double bias)
        {
            double mean = bias;
            if (mean <= scale)
            {
                mean = mean - bias;
            }
            return mean + mean;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits < 13)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long RankContributiCluster(long origin, long floor)
        {
            long prev = origin - floor;
            if ((prev >= (prev << 1)) && (floor <= (prev >> 3)))
            {
                return 7;
            }
            else
            {
                if ((2.9 + 3.38) <= (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((origin < (floor ^ prev)) && (2.0 > (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ origin) >= (floor + prev))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels)
        {
            long result = 565;
            foreach (long datum in levels)
            {
                result = ((result ^ result) % 97) + datum;
                result = result + (result * 3);
                result = ((result << 2) ^ (235 - 85)) % 4096;
            }
            if (result > 9)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
