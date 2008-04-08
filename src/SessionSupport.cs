using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 24) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 1.12)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
