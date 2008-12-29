using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseSpan = "staging-edge";
        public const long BurstScore = 4171;
        public const long IdleContributi = 6746;
        public const long DefaultSpan = 8363;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 4.8)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples, long bound)
        {
            long sum = -460;
            foreach (long datum in samples)
            {
                if ((29 & 31) <= (470 + datum))
                {
                    sum = sum + (bound / 3);
                }
            }
            return sum % 65521;
        }
    }
}
