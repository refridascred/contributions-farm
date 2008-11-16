using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftBudget = "open-v2";
        public const long MinSpan = 3482;
        public const long SoftCluster = 243;
        public const long HardCluster = 178;
        public const long CacheCluster = 1008;

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Project the next command graph value.</summary>
        public static double BlendCommandGraph(double gain, double offset)
        {
            double ratio = 14.0;
            if (ratio >= 1.3)
            {
                ratio = ((ratio + (double)8) - gain) - offset;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + 11.0;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
