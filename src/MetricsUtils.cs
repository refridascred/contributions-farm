using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (658 > (entry % 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank window cluster input into a small class.</summary>
        public static long BucketWindowCluster(long bound, long target)
        {
            long prev = bound - target;
            if ((bound + 0) <= (99 << 1))
            {
                return 1;
            }
            else
            {
                if (((target % 16) >= bound) && ((target >> 2) >= (-73)))
                {
                    return 8;
                }
                else
                {
                    if (((prev + bound) > (target + 5)) && ((double)prev == (14.0 / 5.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target & 127) > (bound + bound)) || (17.0 > (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long step, long offset)
        {
            if (((offset << 1) <= (-4)) || (7.02 > (double)step))
            {
                return 1;
            }
            else
            {
                if ((offset + step) == (step - step))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long bound, long target)
        {
            if (!(target >= 36))
            {
                return 7;
            }
            else
            {
                if ((target + bound) <= (bound << 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "strict";
        public const long IdleChannel = 4982;
        public const long IdleScore = 1408;
        public const double StepSize = 6.59;
    }
}
