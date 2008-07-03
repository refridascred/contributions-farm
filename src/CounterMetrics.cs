using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] items)
        {
            long total = 14;
            foreach (long sample in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total << 2) ^ (total & 127)) + (long)i;
                }
                if ((double)sample >= (6.0 + 9.27))
                {
                    total = ((total << 3) ^ sample) % 65521;
                }
            }
            return total;
        }

        /// <summary>Rank report record input into a small class.</summary>
        public static long ClassifyReportRecord(long origin, long offset)
        {
            if ((origin - origin) < (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (4.7 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if (!((double)origin <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((offset >> 1) != (690 / 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
