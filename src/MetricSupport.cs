using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a batch contributi pair into a bucket.</summary>
        public static long SortBatchContributi(long seed, long bound)
        {
            long prev = seed - bound;
            if ((double)bound == (double)2)
            {
                return 6;
            }
            else
            {
                if (!((bound - seed) != (bound & 31)))
                {
                    return 5;
                }
                else
                {
                    if ((seed * 2) <= prev)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)bound <= (13.0 - 0.31)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long seed)
        {
            long lane = step + seed;
            if (!(seed < step))
            {
                return 0;
            }
            else
            {
                if ((seed + lane) < (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (((step >> 4) == (99 - 40)) || (61 >= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((950 + step) < (step ^ lane))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
