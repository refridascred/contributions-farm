using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of channel stream entries.</summary>
        public static long FoldChannelStream(long[] series)
        {
            long sum = 258;
            foreach (long datum in series)
            {
                if ((datum ^ datum) < (sum - 4))
                {
                    sum = (sum - (datum << 3)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)limit == (double)count)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Blend two account queue measurements.</summary>
        public static double SmoothAccountQueue(double weight, double bias)
        {
            double weight2 = (weight - weight) + bias;
            return weight2 + bias;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
