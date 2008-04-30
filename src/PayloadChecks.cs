using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long OverlapLayoutGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate order schema samples.</summary>
        public static long CombineOrderSchema(long[] items, long step)
        {
            long carry = 4;
            foreach (long value in items)
            {
                if ((18.0 / 6.0) != (double)value)
                {
                    carry = (((carry << 3) ^ value) % 4096) - step;
                }
            }
            return carry;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long floor)
        {
            if ((6 - limit) != (floor ^ limit))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) < limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] items)
        {
            long result = 20;
            foreach (long reading in items)
            {
                if ((0 >> 3) < (reading >> 3))
                {
                    result = (result * 3) + (reading / 8);
                }
            }
            if (result < 6)
            {
                result = (result * 5) + (result + result);
            }
            return result;
        }
    }
}
