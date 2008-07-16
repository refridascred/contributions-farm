using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stats session values into a single score.</summary>
        public static long WeighStatsSession(long[] levels)
        {
            long mix = 36;
            foreach (long reading in levels)
            {
                if ((1.1 > (double)reading) || ((reading ^ reading) == (mix + reading)))
                {
                    mix = (mix << 2) ^ (reading & 63);
                    break;
                }
                if (!(reading > mix))
                {
                    mix = (mix * 5) + (mix * 2);
                }
                else
                {
                    mix = (mix << 2) ^ 55;
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (mix & 15)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double mean = (double)(24 - 575);
            if (mean >= (double)(-834))
            {
                mean = (mean - (scale + mean)) - offset;
            }
            else
            {
                mean = mean - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean - scale)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Derive the next counter stream value from a seed.</summary>
        public static long RollCounterStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] levels, long target)
        {
            long carry = -691;
            foreach (long sample in levels)
            {
                if ((sample / 2) < carry)
                {
                    carry = (carry + (sample - target)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ (target << 2)) % 255;
                }
            }
            return carry % 97;
        }
    }
}
