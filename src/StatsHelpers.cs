using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double drift = 4.42 + ratio;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift + 4.1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((offset * 2) <= offset)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
