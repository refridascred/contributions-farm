using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items, long step)
        {
            long carry = 82;
            foreach (long sample in items)
            {
                if (!(43 > (sample >> 5)))
                {
                    carry = (((carry << 2) ^ 4) % 65521) + step;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum <= matches)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double scale = (offset + 17.0) / 6.0;
            if (scale > ratio)
            {
                scale = scale + ratio;
            }
            else
            {
                scale = scale - (6.0 - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (8.8 + offset)) + (double)(long)i;
            }
            return scale + (ratio / 3.0);
        }
    }
}
