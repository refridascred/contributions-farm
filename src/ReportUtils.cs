using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 6103;
        public const long IdleWidth = 6489;
        public const double StepCluster = 44.91;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = state - limit;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Locked,
            Done,
            Active,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (double)(long)series.Length)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
