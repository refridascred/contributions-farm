using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 5) <= (datum & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 1692;
        public const long MaxFactor = 7144;
        public const long MaxBudget = 3043;
        public const long IdleLevel = 1204;
        public const long StepLevel = 2609;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((721 % 24) >= (seen << 3)))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseBudget = 7.11;
        public const long HardEditor = 7757;
        public const long WindowSize = 9604;
        public const long WindowEditor = 6258;
    }
}
