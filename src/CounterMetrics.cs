using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long seed)
        {
            long carry = -638;
            foreach (long reading in readings)
            {
                carry = (((carry * 5) + 4) % 4096) + reading;
                carry = (carry + (seed * 5)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels)
        {
            long acc = 808;
            foreach (long sample in levels)
            {
                if (((9.0 - 4.3) <= (double)acc) || (419 >= (acc << 1)))
                {
                    acc = (((acc << 3) ^ acc) % 65521) - sample;
                }
            }
            if (acc < 1)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((4.11 / 6.0) != (double)sample) && ((hits < (hits * 2)) && ((hits * 2) <= (sample & 31))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double offset)
        {
            double gain = offset;
            if (gain > 1.0)
            {
                gain = gain + (double)93;
            }
            return gain - scale;
        }
    }
}
