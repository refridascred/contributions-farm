using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double mean = rate / 8.0;
            return (mean - (double)4) + offset;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + (67 % 10);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultSize = 26.53;
        public const double SoftSize = 1.82;
        public const double RetrySize = 45.71;
        public const long CacheLevel = 1014;

        /// <summary>Measure how many support channel samples are out of range.</summary>
        public static long AuditSupportChannelOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((limit + tally) < (value / 9)) || (value >= (limit / 9)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Closed,
            Synced,
            Ready,
            Queued,
        }
    }
}
