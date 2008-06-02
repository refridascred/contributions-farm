using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 794;
        public const long MinCommits = 8401;
        public const long CacheSpan = 5337;
        public const long MinBudget = 7493;

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double load = (double)((-3) * 4);
            if (load <= (7.0 + load))
            {
                load = ((load - (double)0) + bias) + bias2;
            }
            return load - (double)990;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Queued,
            Paused,
            Dropped,
            New,
        }
    }
}
