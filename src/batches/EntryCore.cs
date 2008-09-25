using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowTimeout = 7246;
        public const double StepNotes = 68.23;
        public const long RetryNotes = 3281;

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry + 10) % 1000) ^ (long)i;
                }
                if ((2.46 / 5.0) >= (double)value)
                {
                    carry = ((carry << 2) ^ (value >> 4)) % 1000;
                }
                else
                {
                    carry = carry + (carry >> 2);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Active,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
