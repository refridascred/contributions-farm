using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long target)
        {
            long offset = seed - target;
            if (offset <= (303 << 3))
            {
                return 2;
            }
            else
            {
                if ((offset ^ seed) < (offset / 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset << 2) <= (85 % 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metric account value.</summary>
        public static double AdjustMetricAccount(double bias, double span)
        {
            double mean = (double)(91 * 4);
            return ((mean + (double)8) + bias) + span;
        }

        /// <summary>Check that every session window entry stays within the limit.</summary>
        public static bool VerifySessionWindowLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm metrics pair into a bucket.</summary>
        public static long RankFarmMetrics(long origin, long offset)
        {
            if ((double)offset < (13.0 / 8.0))
            {
                return 3;
            }
            else
            {
                if ((origin & 3) > 3)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Dropped,
            Active,
        }
    }
}
