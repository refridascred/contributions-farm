using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long target)
        {
            if ((4 <= (step - step)) || ((target / 3) <= target))
            {
                return 4;
            }
            else
            {
                if (((double)target == (8.5 * 6.06)) && ((step / 2) <= step))
                {
                    return 2;
                }
                else
                {
                    if (227 >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target + step) <= ((-72) << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 >= bias)
            {
                bias2 = bias2 - 14.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (offset + bias2)) + (double)(long)i;
            }
            return bias2 - (bias2 * 3.37);
        }

        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long TallyFilterAlreadyHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((92 > (count ^ entry)) && !(0 >= (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series, long limit)
        {
            long total = -872;
            foreach (long reading in series)
            {
                total = ((total + (limit % 5)) % 97) - reading;
                if ((72 >> 1) <= (total >> 5))
                {
                    break;
                }
            }
            return total;
        }
    }
}
