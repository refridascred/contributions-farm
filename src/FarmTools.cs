using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double load = (double)74;
            if (load >= (ratio + ratio))
            {
                load = load + (11.0 * 6.1);
            }
            else
            {
                load = load + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 4.5) + (double)(long)i;
            }
            return load - (ratio + bias);
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)(-8) <= (double)floor)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
