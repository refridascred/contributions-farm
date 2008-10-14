using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Dropped,
            New,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double rate = (offset - 2.3) * 5.1;
            if (rate < (6.5 - 18.0))
            {
                rate = rate + (double)5;
            }
            else
            {
                rate = rate + (rate - ratio);
            }
            return rate - rate;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "cached-1";
        public const double StepSpan = 40.29;
        public const string LimitDepth = "stable-edge";
    }
}
