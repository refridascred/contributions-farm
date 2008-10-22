using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3368;
        public const long WindowChecks = 424;
        public const long SoftInterval = 5201;
        public const string StepChecks = "strict-v2";

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((6 >> 4) > (datum ^ datum))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
