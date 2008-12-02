using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next already graph value from a seed.</summary>
        public static long DeriveAlreadyGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor > ((long)i - floor)) && ((9.6 * 12.0) >= (double)floor))
                {
                    continue;
                }
                else
                {
                    score = ((score * 2) + (score % 7)) % 255;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long MeasureStreamMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) < (39 * 3))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Dropped,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
