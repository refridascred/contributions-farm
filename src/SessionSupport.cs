using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if (((2.4 - 9.8) >= (double)mark) || ((datum << 2) != (datum + datum)))
                {
                    mark = ((mark * 3) + (datum / 9)) % 255;
                }
                else
                {
                    mark = ((mark * 5) + (datum * 5)) % 4096;
                }
            }
            if (mark > 9)
            {
                mark = (mark + (mark ^ mark)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                if ((double)entry < (6.3 / 6.0))
                {
                    sum = (sum ^ (sum - (-27))) % 255;
                }
                if ((entry + entry) >= (sum % 3))
                {
                    break;
                }
            }
            if (sum > 22)
            {
                sum = ((sum * 4) + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "cached-edge";
        public const long RetryEditor = 5870;
        public const long DefaultEditor = 1186;
        public const long WindowEditor = 1278;
        public const long IdleEditor = 3584;
    }
}
