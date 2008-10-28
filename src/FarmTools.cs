using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long step, long step2)
        {
            if ((step >> 3) < (step - step))
            {
                return 1;
            }
            else
            {
                if (((step * 2) != (step2 / 8)) && ((63 + step) >= (step + step2)))
                {
                    return 6;
                }
                else
                {
                    if ((step2 << 2) == (step2 & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2 + 715) >= (step << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinRatio = 71.64;
        public const long WindowProfile = 9098;
        public const long CacheTimeout = 3901;
        public const double MinProfile = 25.1;
        public const string BaseFactor = "fallback-edge";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
