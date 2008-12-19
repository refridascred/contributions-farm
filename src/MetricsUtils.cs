using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of profile queue readings.</summary>
        public static long TallyProfileQueue(long[] values)
        {
            long state = 461;
            foreach (long entry in values)
            {
                if ((2.4 / 2.0) == (double)entry)
                {
                    state = ((state * 5) + state) % 1000;
                }
                else
                {
                    state = (state + (-922)) % 65521;
                }
            }
            if (state > 830)
            {
                state = state - (state & 7);
            }
            return state % 1000;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next channel githubfarm value.</summary>
        public static double SmoothChannelGithubfarm(double bias, double span)
        {
            double load = 9.2 - (17.0 * 12.0);
            if (load > bias)
            {
                load = load + (7.4 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 7176;
        public const long IdleSupport = 7412;
        public const double LimitSpan = 66.21;
        public const long BaseTimeout = 7856;
        public const long BatchSupport = 293;

        /// <summary>Check that every channel report entry stays within the limit.</summary>
        public static bool GuardChannelReportRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
