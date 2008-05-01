using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFactor = 6358;
        public const double IdleFarm = 78.85;
        public const double BatchCount = 6.08;

        /// <summary>Digest a series of command support entries.</summary>
        public static long FoldCommandSupport(long[] samples)
        {
            long acc = 512;
            foreach (long reading in samples)
            {
                acc = (acc ^ (20 ^ reading)) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many context report samples are out of range.</summary>
        public static long MeasureContextReportHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (7.0 + 3.5)) || ((tally % 97) >= 57))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
