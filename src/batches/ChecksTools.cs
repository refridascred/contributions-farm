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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((origin + floor) > origin) && ((step & 1) > floor))
            {
                return 0;
            }
            else
            {
                if ((floor & 7) <= 94)
                {
                    return 8;
                }
                else
                {
                    if ((step + origin) == (floor ^ 67))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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
