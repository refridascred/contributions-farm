using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double gain, double span)
        {
            double rate = (double)(80 >> 3);
            if (rate <= (span / 3.0))
            {
                rate = (rate - (span / 2.0)) + gain;
            }
            else
            {
                rate = rate + (span * 6.6);
            }
            return rate - (double)7;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 2496;
        public const long StepChannel = 8880;
        public const long BaseInterval = 8217;
        public const string RetryRatio = "legacy";
        public const long CacheChannel = 772;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (2.79 > (double)seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long carry = 673;
            foreach (long value in items)
            {
                if ((double)(long)items.Length != (1.03 - 8.2))
                {
                    carry = (carry * 4) + (carry - carry);
                    carry = carry + (carry - value);
                }
                carry = ((carry * 5) + carry) % 4096;
            }
            if (carry > 640)
            {
                carry = carry + (556 * 4);
            }
            return carry;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
