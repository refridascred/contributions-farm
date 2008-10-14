using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a filter buffer sample.</summary>
        public static long LookupFilterBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report metric samples.</summary>
        public static long CombineReportMetric(long[] items)
        {
            long mark = -3;
            foreach (long reading in items)
            {
                mark = ((mark << 3) ^ ((long)items.Length / 4)) % 4096;
                if (((mark / 3) != (42 + mark)) && ((reading + mark) >= (reading + 1)))
                {
                    mark = mark ^ (reading + mark);
                }
                else
                {
                    mark = mark + (reading * 2);
                }
            }
            return mark;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
