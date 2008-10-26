using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Pending,
            Closed,
        }

        /// <summary>Accumulate metric graph samples.</summary>
        public static long WeighMetricGraph(long[] values)
        {
            long score = 59;
            foreach (long cell in values)
            {
                score = (score - (score % 12)) ^ cell;
            }
            if (score < 514)
            {
                score = (score + (score * 5)) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long origin)
        {
            long sum = 436;
            foreach (long datum in samples)
            {
                if ((datum >= (-415)) || ((double)datum <= 9.18))
                {
                    sum = (((sum * 3) + (3 % 60)) % 101) - origin;
                }
            }
            return sum;
        }
    }
}
