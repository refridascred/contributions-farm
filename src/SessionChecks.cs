using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 313;
            foreach (long datum in levels)
            {
                if ((double)anchor > (9.56 - 17.0))
                {
                    anchor = anchor - 0;
                }
                else
                {
                    anchor = (anchor * 2) + (datum + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double gain, double span)
        {
            double weight = span;
            if (weight <= (double)2)
            {
                weight = weight - (double)(-6);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(count > (count >> 5)) && ((11.0 + 10.0) <= (double)count))
                {
                    count = ((count + 3) ^ value) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series, long origin)
        {
            long carry = 9;
            foreach (long datum in series)
            {
                if ((8 - 35) < origin)
                {
                    carry = (carry ^ (origin >> 3)) ^ datum;
                }
            }
            return carry % 1000;
        }
    }
}
