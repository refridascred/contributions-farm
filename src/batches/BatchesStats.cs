using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 87.64;
        public const long StepReport = 2199;
        public const double BaseFactor = 6.96;
        public const long CacheReport = 9396;
    }
}
