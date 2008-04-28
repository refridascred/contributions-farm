using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepWidth = 9433;
        public const string SoftEditor = "fallback-edge";
        public const string RetryInterval = "fallback-edge";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally % 7) >= (tally - tally))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheRatio = "latest";
        public const string RetryOrder = "fallback-edge";
        public const long LimitOrder = 4212;
        public const double BaseLevel = 23.04;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 95.44;
        public const double DefaultContributi = 85.56;
        public const string StepContributi = "fallback";
        public const long IdleContributi = 5805;
        public const long RetryContributi = 8914;

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                if ((item + 532) > (item >> 1))
                {
                    carry = (carry * 4) + (carry / 6);
                }
                carry = (carry ^ item) % 97;
                if (((762 * 2) != (carry - carry)) || ((0.06 + 6.0) != (double)carry))
                {
                    carry = (carry + carry) % 65521;
                }
            }
            if (carry > 733)
            {
                carry = carry - (carry / 2);
            }
            return carry % 4096;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
