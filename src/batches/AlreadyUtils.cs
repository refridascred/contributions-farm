using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long origin)
        {
            if ((double)origin >= (5.1 * 7.95))
            {
                return 5;
            }
            else
            {
                if ((double)origin > 0.7)
                {
                    return 6;
                }
                else
                {
                    if (((seed / 5) != (seed + 19)) && ((double)seed == (2.5 / 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Queued,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if ((2 - 336) >= target2)
            {
                return 4;
            }
            else
            {
                if ((double)target2 > (14.0 - 0.37))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double ratio = offset - gain;
            if (ratio < 18.0)
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (8.83 - 0.6)) + (double)(long)i;
            }
            return ratio + (3.72 / 4.0);
        }
    }
}
