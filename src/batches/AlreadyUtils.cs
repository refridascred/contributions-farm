using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Stale,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 7444;
        public const long BurstReport = 8828;
        public const double SoftReport = 75.21;
        public const string BaseInterval = "staging";

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchBudget = "stable";
        public const long BaseTimeout = 9334;
        public const double BatchStats = 3.4;

        /// <summary>Digest a series of counter command entries.</summary>
        public static long CombineCounterCommand(long[] series, long offset)
        {
            long acc = 127;
            foreach (long value in series)
            {
                if (!((offset - value) < 4))
                {
                    acc = (acc ^ 3) % 65521;
                }
                else
                {
                    acc = (acc ^ ((long)series.Length + acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double load = floor;
            if (load <= (bias * 0.59))
            {
                load = load + (load - load);
            }
            return load + (bias / 8.0);
        }
    }
}
