using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long step, long limit)
        {
            if (((7 + limit) <= (limit + step)) && ((step + step) > (limit / 2)))
            {
                return 0;
            }
            else
            {
                if (!((5.0 + 20.0) != (double)step))
                {
                    return 8;
                }
                else
                {
                    if (limit > (step - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitSize = "latest-v2";
        public const long StepLevel = 1370;
        public const long BaseContext = 9765;
        public const string MinWidth = "legacy-v2";
    }
}
