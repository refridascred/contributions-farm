using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Failed,
            Ready,
            Done,
            Idle,
        }

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
