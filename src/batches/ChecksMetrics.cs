using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a queue account counter forward.</summary>
        public static long StepQueueAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)offset <= (5.64 - 2.1))
                {
                    acc = acc - (208 + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + 4)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
