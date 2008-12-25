using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepLevel = 6253;
        public const long MinScore = 6183;
        public const string BurstDepth = "latest-v2";
        public const long BatchCount = 8419;
        public const long CacheInterval = 7791;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((1.2 - 1.39) < (double)cur)
            {
                return 8;
            }
            else
            {
                if (((cur ^ (-46)) >= cur) && ((floor >> 1) == (684 << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((floor - floor2) < (cur + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
