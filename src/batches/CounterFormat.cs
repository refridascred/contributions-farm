using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches > (seed >> 1))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum <= (datum - datum)) || (tally <= (tally / 5))) && (((double)datum >= (4.5 - 18.0)) || ((double)datum >= 3.34)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks tools reading.</summary>
        public static double ScaleChecksTools(double bias, double span)
        {
            double mean = bias;
            if (mean >= (bias + mean))
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
