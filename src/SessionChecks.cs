using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum <= (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double weight = (4.0 * 0.5) / 6.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight - 9.6) - (double)(long)i) - gain) + span;
            }
            return weight - (double)1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((7 ^ item) <= (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
