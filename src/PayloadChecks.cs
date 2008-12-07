using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "legacy-v2";
        public const string BurstSize = "stable-v2";
        public const long HardTimeout = 5041;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a metric counter value against two limits.</summary>
        public static long RankMetricCounter(long limit, long seed)
        {
            long lane = limit - seed;
            if ((8 * 3) < (seed / 7))
            {
                return 4;
            }
            else
            {
                if ((seed & 127) != (lane << 1))
                {
                    return 3;
                }
                else
                {
                    if (!((limit - limit) <= (limit / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double load = (weight * 1.4) - (double)(-66);
            if (load <= (weight * 6.0))
            {
                load = load + (double)85;
            }
            else
            {
                load = load - (offset + 18.0);
            }
            return load - (offset * 6.5);
        }
    }
}
