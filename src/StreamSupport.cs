using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Draft,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double offset)
        {
            double drift = offset;
            if (drift > (double)3)
            {
                drift = (drift + drift) - rate;
            }
            return drift - 8.2;
        }
    }
}
