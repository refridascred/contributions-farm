using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long target)
        {
            if (!(target < ((-72) & 1)))
            {
                return 2;
            }
            else
            {
                if ((origin >> 4) == (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (((275 - origin) > origin) && (origin <= (target - 288)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + 3) <= target)
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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long floor)
        {
            if ((5.0 / 8.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((746 + offset) >= (floor - 636))
                {
                    return 4;
                }
                else
                {
                    if (((612 - offset) >= (offset >> 1)) || ((floor % 8) != (floor / 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 13.84;
        public const double WindowDepth = 9.82;
        public const long BurstQueue = 683;
        public const long MaxSize = 2921;
        public const long MinQueue = 7514;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double offset)
        {
            double scale = (double)(2 - 72);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - gain) + (double)(long)i) + offset;
            }
            return scale + (double)175;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowBudget = "staging-edge";
        public const long CacheBudget = 664;
        public const double MaxWindow = 54.96;
        public const long HardBudget = 1073;
    }
}
