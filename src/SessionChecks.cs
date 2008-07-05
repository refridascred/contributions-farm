using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double offset)
        {
            double load = ratio / 6.0;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (load * 3.0)) + (double)(long)i) + offset;
            }
            return load - ratio;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if ((double)sample <= (3.0 - 2.0))
                {
                    acc = (acc - (sample << 1)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (sample + sample)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length < (seen << 2))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
