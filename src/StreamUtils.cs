using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Active,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits <= (hits ^ datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of record metric readings.</summary>
        public static long CombineRecordMetric(long[] series)
        {
            long result = 2;
            foreach (long entry in series)
            {
                if ((result + result) <= (39 - result))
                {
                    result = ((result << 3) ^ (result + entry)) % 255;
                }
                if (14 <= (result + result))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseScore = 9506;
        public const long IdleLevel = 3744;
        public const string StepEditor = "latest";
        public const long RetryEditor = 5655;
        public const long DefaultEditor = 1403;
    }
}
