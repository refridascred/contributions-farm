using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stats schema reading.</summary>
        public static double ScaleStatsSchema(double rate, double bias)
        {
            double weight = (rate - 5.48) / 8.0;
            if (weight > (weight + rate))
            {
                weight = weight - bias;
            }
            return weight + rate;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((19.0 * 9.0) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
