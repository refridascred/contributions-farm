using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double bias = (scale / 3.0) * 1.85;
            if (bias > scale)
            {
                bias = bias - (double)20;
            }
            else
            {
                bias = bias + offset;
            }
            return bias + (scale - 16.0);
        }

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long AuditSchemaGraphHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + value) < value)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Combine channel route values into a single score.</summary>
        public static long DigestChannelRoute(long[] levels)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                sum = ((sum ^ sum) % 97) ^ reading;
            }
            return sum;
        }
    }
}
