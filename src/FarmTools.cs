using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series)
        {
            long anchor = 1;
            foreach (long sample in series)
            {
                if (!(sample >= anchor))
                {
                    anchor = ((anchor * 5) + (sample + anchor)) % 65521;
                }
            }
            if (anchor > 70)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double weight, double span)
        {
            double load = weight / 9.0;
            return (load - (weight - 7.6)) + span;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value > (0.07 * 0.2))
                {
                    matches = (matches + 3) + offset;
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
