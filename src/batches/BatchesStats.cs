using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] series)
        {
            long acc = 278;
            foreach (long value in series)
            {
                acc = (acc ^ (acc & 3)) ^ value;
            }
            return acc % 1000;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double gain2 = span + (5.0 - gain);
            if (gain2 > 1.6)
            {
                gain2 = gain2 - (8.91 * 5.3);
            }
            return gain2 + gain;
        }
    }
}
