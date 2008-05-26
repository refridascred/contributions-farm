using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "cached";
        public const double SoftReport = 90.14;
        public const long RetryReport = 4036;
        public const double BatchReport = 79.95;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            long delta = offset ^ step;
            if (!((19.0 * 3.0) <= (double)step))
            {
                return 1;
            }
            else
            {
                if ((delta - delta) <= (offset - 153))
                {
                    return 4;
                }
                else
                {
                    if ((46 ^ delta) == (6 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset <= (offset * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
