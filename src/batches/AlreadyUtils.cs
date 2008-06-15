using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long diff = step + origin;
            if (((step + origin) < (diff << 2)) && ((double)origin > (20.0 + 15.0)))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (6.0 * 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff > (4.4 * 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin > (double)193) || (644 < step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long step2)
        {
            if ((double)step2 >= 1.6)
            {
                return 5;
            }
            else
            {
                if (!((step / 3) <= step2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 6360;
        public const long RetryCounter = 4609;
        public const long DefaultRatio = 606;
        public const string IdleRatio = "fallback-edge";
    }
}
