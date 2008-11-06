using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((7.06 * 13.0) < (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "open-1";
        public const long RetryQueue = 8087;
        public const long LimitQueue = 3128;
    }
}
