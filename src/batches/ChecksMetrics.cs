using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] data, long floor)
        {
            long carry = 400;
            foreach (long item in data)
            {
                if ((floor >> 1) <= (item ^ (long)data.Length))
                {
                    carry = carry ^ ((long)data.Length - 37);
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile account values into a single score.</summary>
        public static long TallyProfileAccount(long[] series, long offset)
        {
            long acc = 4;
            foreach (long entry in series)
            {
                if (!((entry % 5) != (acc - (long)series.Length)))
                {
                    acc = (((acc << 3) ^ (entry << 2)) % 101) - offset;
                }
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long bound)
        {
            long gap = origin - bound;
            if ((8 ^ gap) < (bound ^ gap))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) <= 3)
                {
                    return 4;
                }
                else
                {
                    if ((550 + bound) < (-4))
                    {
                        return 6;
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
