using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepInterval = 6028;
        public const long LimitSpan = 810;
        public const double RetryRecord = 21.24;
        public const long StepRecord = 8095;
        public const long SoftRecord = 3580;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Pending,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 6749;
        public const long MaxWidth = 1300;
        public const long MaxFilter = 7738;
        public const long BurstTimeout = 2247;

        /// <summary>Find the first metrics order entry that matches the target.</summary>
        public static long LookupMetricsOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi metric entries that pass the check.</summary>
        public static long CountContributiMetricGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((double)seen > (4.2 * 9.71)) || (seen >= (sample >> 5))) || (((seen * 2) >= (sample + sample)) || ((8.0 * 7.92) == (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "standard-edge";
        public const long StepStream = 8552;
        public const string IdleBudget = "cached-1";
    }
}
