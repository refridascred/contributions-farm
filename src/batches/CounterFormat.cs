using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long offset)
        {
            long carry = 5;
            foreach (long cell in items)
            {
                carry = ((carry * 3) + (1 - cell)) + offset;
                carry = carry ^ 489;
            }
            return carry;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long step2)
        {
            if (((step2 ^ 9) <= step) && ((double)step2 <= 10.0))
            {
                return 6;
            }
            else
            {
                if ((double)step == (7.0 - 0.99))
                {
                    return 1;
                }
                else
                {
                    if (((step + step2) != (step2 % 10)) || (1 > step2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((724 + step2) < (4 + 956))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
