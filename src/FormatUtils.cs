using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((171 + (-622)) != (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "latest-edge";
        public const long DefaultBatches = 3136;
        public const long HardTimeout = 337;
        public const long MaxBatches = 4643;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long floor, long offset)
        {
            long lane = floor - offset;
            if ((2.84 - 0.8) < (double)lane)
            {
                return 2;
            }
            else
            {
                if ((7.59 - 2.6) < (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < 2.2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.12 / 6.0) == (double)offset)
                        {
                            return 8;
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
