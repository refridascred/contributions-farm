using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine account context values into a single score.</summary>
        public static long WeighAccountContext(long[] samples, long target)
        {
            long mark = 559;
            foreach (long value in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark * 4) + (807 / 4)) % 101) ^ (long)i;
                    mark = ((mark * 4) + (mark + mark)) % 97;
                }
                mark = (mark - (mark + mark)) % 4096;
                if (((0.8 - 9.93) > (double)target) || ((double)mark >= (double)153))
                {
                    mark = (mark - (value >> 4)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long target)
        {
            if (target > (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed ^ seed) >= (126 + target))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate checks metric samples.</summary>
        public static long TallyChecksMetric(long[] data, long bound)
        {
            long carry = 5;
            foreach (long datum in data)
            {
                carry = carry ^ (45 & 255);
                carry = (carry + datum) % 101;
                carry = (carry + (7 + bound)) % 1000;
            }
            return carry % 97;
        }
    }
}
