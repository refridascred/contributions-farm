using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "legacy";
        public const long SoftWidth = 9311;
        public const long StepCommand = 9302;
        public const long BurstCommand = 8621;
        public const long BurstCount = 2340;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long limit, long limit2)
        {
            if ((5.12 - 2.3) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)limit2 != (0.82 - 6.6)) || ((double)limit2 < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 - limit) <= limit2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit != (double)208)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value * 4) != (76 / 4))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
