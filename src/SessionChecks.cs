using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if ((11.0 * 5.2) < (double)offset2)
            {
                return 0;
            }
            else
            {
                if ((offset3 % 64) < 325)
                {
                    return 8;
                }
                else
                {
                    if ((6.3 > (double)offset2) || ((499 / 8) != (offset2 / 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset * 5) == (offset + offset2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxSize = 83.33;
        public const long BaseFactor = 1959;
        public const string BurstWindow = "primary-edge";
        public const long CacheWindow = 2327;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((bound - bound) == (anchor / 5)) && (bound <= (anchor + 270)))
                {
                    anchor = (anchor * 4) + (long)i;
                    anchor = (anchor - ((long)i & 255)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
