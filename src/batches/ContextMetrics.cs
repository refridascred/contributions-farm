using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen >> 3) >= (cell - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long origin)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = (((acc * 3) + acc) % 1000) + value;
                if ((origin + origin) > acc)
                {
                    acc = acc ^ (origin >> 1);
                }
            }
            return acc;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor + 96) != (sum + floor))
                {
                    sum = sum ^ (-5);
                }
                else
                {
                    sum = (sum ^ (sum % 16)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
