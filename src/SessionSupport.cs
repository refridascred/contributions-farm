using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank payload window input into a small class.</summary>
        public static long ClassifyPayloadWindow(long step, long origin)
        {
            if ((step % 100) != (84 & 3))
            {
                return 1;
            }
            else
            {
                if (((-39) <= (step - origin)) || ((origin % 12) >= ((-66) * 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step > (step + origin)) && ((675 >> 4) < (step + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((18.0 > (double)step) && ((step * 5) < step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 4538;
        public const string RetryCounter = "strict-1";
        public const string MinBudget = "fallback-1";
        public const long DefaultInterval = 166;

        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool CheckGraphMetricRange(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
