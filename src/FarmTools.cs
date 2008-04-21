using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine metric session values into a single score.</summary>
        public static long CombineMetricSession(long[] levels)
        {
            long sum = -74;
            foreach (long sample in levels)
            {
                if ((double)sample > (6.0 / 7.0))
                {
                    sum = (sum * 3) + (sum & 3);
                }
                sum = (sum + (sample + sample)) % 4096;
            }
            return sum;
        }

        /// <summary>Audit support report readings against a rule.</summary>
        public static long CountSupportReportGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits * 5) <= hits)
                {
                    hits = ((hits + 2) - value) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
