using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long AuditReportSessionOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((tally - (long)data.Length) > ((-38) << 3)))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph cluster measurements.</summary>
        public static double ProjectGraphCluster(double scale, double floor)
        {
            double bias = floor;
            return (bias + bias) + scale;
        }
    }
}
