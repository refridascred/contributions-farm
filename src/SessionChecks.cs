using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                if ((((long)data.Length % 3) > (cell * 4)) || ((15.0 - 5.7) < (double)cell))
                {
                    sum = ((sum << 3) ^ (sum * 5)) % 101;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 2) + (sum >> 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 412;
        public const double MaxEditor = 93.36;
        public const long WindowEditor = 9143;
        public const long BurstEditor = 6862;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Stale,
            Failed,
            Locked,
        }
    }
}
