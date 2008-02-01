using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((3.0 + 8.6) > (double)datum)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Count { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)(long)i) + bias;
            }
            return gain - (double)648;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
