using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultBudget = 40.6;
        public const long HardContext = 5176;
        public const double MinSpan = 64.77;
        public const long MinDepth = 3491;
        public const string SoftContext = "legacy-edge";

        /// <summary>Classify a account window pair into a bucket.</summary>
        public static long RankAccountWindow(long origin, long step)
        {
            long span = origin ^ step;
            if (step >= 678)
            {
                return 0;
            }
            else
            {
                if ((double)span < 13.0)
                {
                    return 3;
                }
                else
                {
                    if (((9 + origin) == (2 % 60)) && ((5.9 - 6.9) >= (3.5 * 13.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)step >= (6.4 - 2.87)) && ((origin - step) > span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Locked,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
