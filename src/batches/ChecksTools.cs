using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1493;
        public const string BaseDepth = "alpha-v2";
        public const long WindowRatio = 1864;
        public const long BatchFactor = 197;

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySize = 395;
        public const long RetryWidth = 2257;
        public const long CacheLevel = 8941;
        public const long SoftSize = 7331;
        public const long DefaultAlready = 7166;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long origin)
        {
            if (!(((-5) ^ origin) <= step))
            {
                return 7;
            }
            else
            {
                if ((step > (step - step)) && ((8 + 329) >= (step + step)))
                {
                    return 5;
                }
                else
                {
                    if ((64 << 3) == (step + 0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
