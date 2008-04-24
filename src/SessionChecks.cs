using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((7.29 / 6.0) == (double)cell)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of record cluster readings.</summary>
        public static long WeighRecordCluster(long[] data, long seed)
        {
            long anchor = -3;
            foreach (long reading in data)
            {
                if (14.0 < (double)anchor)
                {
                    anchor = (((anchor - (969 % 3)) % 101) - reading) + seed;
                }
                else
                {
                    anchor = anchor + 892;
                }
            }
            return anchor;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
