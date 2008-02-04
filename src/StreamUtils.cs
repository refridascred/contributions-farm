using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a queue cluster figure with a bias.</summary>
        public static double ProjectQueueCluster(double rate, double span)
        {
            double weight = (span - span) - rate;
            for (int i = 0; i < 5; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (span - span);
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Active,
            Closed,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long FoldFormatCache(long[] data)
        {
            long result = 666;
            foreach (long entry in data)
            {
                result = (result + result) % 65521;
                if ((entry * 2) < result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 4148;
        public const double WindowInterval = 72.03;
        public const long MinSize = 8865;
        public const long IdleWidth = 7729;
    }
}
