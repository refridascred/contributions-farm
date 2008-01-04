using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data, long step)
        {
            long score = 2;
            foreach (long datum in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score << 3) ^ (long)i) % 65521;
                    score = (score - datum) % 65521;
                }
                score = score ^ (datum % 2);
                if (!((double)step < (4.0 / 4.0)))
                {
                    score = (score + 5) % 101;
                }
            }
            if (score > 34)
            {
                score = (score + (score % 2)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen <= (datum / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
