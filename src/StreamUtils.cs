using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a window checks reading.</summary>
        public static double ProjectWindowChecks(double bias, double bias2)
        {
            double gain = (double)8;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (bias / 8.0)) - (double)(long)i) - bias2;
            }
            return gain - bias;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a checks graph pair into a bucket.</summary>
        public static long GradeChecksGraph(long target, long target2)
        {
            long edge = target + target2;
            if ((target + target) >= (979 * 5))
            {
                return 6;
            }
            else
            {
                if (edge < (1 + target2))
                {
                    return 2;
                }
                else
                {
                    if ((edge + edge) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a graph token value against two limits.</summary>
        public static long SortGraphToken(long origin, long origin2)
        {
            long lane = origin - origin2;
            if (((-2) + origin) == (lane + origin))
            {
                return 5;
            }
            else
            {
                if (97 >= lane)
                {
                    return 4;
                }
                else
                {
                    if ((origin & 1) != (lane + origin2))
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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - limit) <= (entry / 6))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
