using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double floor)
        {
            double gain2 = (double)(623 - 8);
            return ((gain2 + 1.71) + gain) + floor;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((bound * 5) > (datum - 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
