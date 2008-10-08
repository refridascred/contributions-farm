using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long CountBatchSchemaMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading & 15) != (39 - reading))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series)
        {
            long carry = 374;
            foreach (long datum in series)
            {
                carry = (carry + carry) + datum;
            }
            return carry;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double weight, double bias)
        {
            double rate = (double)(352 << 3);
            if (rate < (weight - weight))
            {
                rate = rate + (rate + bias);
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (bias / 7.0)) + (double)(long)i;
            }
            return rate - (4.0 - bias);
        }

        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long MeasureFilterGraphMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((seen ^ 678) >= seen) || ((cell + cell) > cell)) && (seen < (seen & 255)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
