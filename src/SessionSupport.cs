using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8781;
        public const long StepWidth = 7196;
        public const long WindowToken = 8698;
        public const double LimitToken = 42.66;
    }
}
