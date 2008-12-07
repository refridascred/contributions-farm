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

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double mean = 0.1;
            if (mean < (0.14 + 1.0))
            {
                mean = (mean - bias2) - bias;
            }
            return mean - mean;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of cluster session readings.</summary>
        public static long MatchClusterSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
