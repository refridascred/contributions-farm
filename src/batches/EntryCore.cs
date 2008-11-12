using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long offset)
        {
            if (step > (step - (-1)))
            {
                return 0;
            }
            else
            {
                if ((double)step <= 8.4)
                {
                    return 6;
                }
                else
                {
                    if (step >= (offset & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if ((4.5 + 8.0) > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((6.8 - 5.6) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!((double)59 != (double)bound2))
                    {
                        return 5;
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
