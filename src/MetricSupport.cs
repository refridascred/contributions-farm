using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up report cluster samples.</summary>
        public static long OverlapReportClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheScore = "legacy-edge";
        public const long BaseSpan = 2687;
        public const string StepSupport = "primary";
        public const long WindowSupport = 5484;

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = carry + (entry - (long)i);
                }
                if ((entry & 255) >= (carry >> 5))
                {
                    carry = ((carry << 2) ^ (carry + entry)) % 4096;
                }
            }
            return carry;
        }
    }
}
