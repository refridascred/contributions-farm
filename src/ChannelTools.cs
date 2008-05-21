using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double span)
        {
            double load = (double)8 - span;
            if (load <= (span + gain))
            {
                load = load + (load + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (gain - load)) - (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((0 * 5) <= (value ^ value)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = ((sum * 4) + (datum - datum)) % 1000;
                if (!(datum <= (sum & 255)))
                {
                    sum = (sum << 3) ^ datum;
                }
                else
                {
                    sum = (sum + (sum & 31)) % 97;
                }
            }
            return sum;
        }
    }
}
