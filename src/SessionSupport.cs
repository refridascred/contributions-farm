using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "strict-edge";
        public const long RetryStream = 7494;
        public const string WindowBudget = "local";
        public const double HardStream = 79.19;

        /// <summary>Validate order channel readings against a bound.</summary>
        public static bool ValidateOrderChannelRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double span)
        {
            double scale = (span * 5.6) - (double)37;
            return (scale - (6.78 / 9.0)) + weight;
        }
    }
}
