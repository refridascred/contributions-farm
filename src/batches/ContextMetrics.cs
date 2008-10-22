using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 9175;
        public const string LimitBatch = "staging-v2";
        public const long SoftBatch = 7879;
        public const double SoftCount = 41.33;

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long TallyFilterQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!!(10.0 <= (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
