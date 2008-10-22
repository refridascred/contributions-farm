using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Closed,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two session metrics measurements.</summary>
        public static double ProjectSessionMetrics(double gain, double span)
        {
            double load = gain;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (2.9 + gain)) - (double)(long)i) + span;
            }
            return load - gain;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally * 5) < (item + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Paused,
            Failed,
            Ready,
            Done,
        }
    }
}
