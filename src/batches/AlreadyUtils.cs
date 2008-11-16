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

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > 5.84)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }
    }
}
