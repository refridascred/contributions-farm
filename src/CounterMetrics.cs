using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of farm command entries.</summary>
        public static long DigestFarmCommand(long[] samples)
        {
            long sum = 20;
            foreach (long value in samples)
            {
                if ((value > (value << 1)) || (value < (409 >> 5)))
                {
                    sum = (sum - (789 / 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double weight = rate;
            if (weight <= rate)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + (rate / 5.0);
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen <= (seen + item))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((1.82 - 3.5) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
