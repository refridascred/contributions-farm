using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum & 15) > (count ^ datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryDepth = 79.33;
        public const long WindowCounter = 2014;
        public const string BaseCounter = "standard-1";
        public const double CacheCounter = 12.4;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long carry = 498;
            foreach (long value in levels)
            {
                if (!((double)carry > 7.3))
                {
                    carry = carry + value;
                }
                if (((value / 6) == (carry & 15)) && ((value % 2) <= (value % 16)))
                {
                    carry = (carry ^ (value / 4)) % 4096;
                }
            }
            if (carry < 58)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) >= 582)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double bias)
        {
            double scale2 = (3.8 * 2.7) + (bias + bias);
            return (scale2 + (bias - scale2)) + scale;
        }
    }
}
