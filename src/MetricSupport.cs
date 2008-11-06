using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long origin, long origin2)
        {
            if (665 > (4 ^ origin2))
            {
                return 8;
            }
            else
            {
                if ((65 % 7) > (origin ^ origin2))
                {
                    return 5;
                }
                else
                {
                    if (!((double)origin != (1.0 * 3.4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin2 + origin) <= (origin + origin2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
