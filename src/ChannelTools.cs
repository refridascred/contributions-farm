using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long limit, long origin)
        {
            long gap = limit ^ origin;
            if ((limit + gap) == (gap - limit))
            {
                return 6;
            }
            else
            {
                if (!((gap % 60) < limit))
                {
                    return 5;
                }
                else
                {
                    if (!(origin <= (limit & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.77 + 13.0) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long bound)
        {
            long result = 41;
            foreach (long cell in values)
            {
                if (!((cell * 5) <= (cell * 2)))
                {
                    result = ((result - (cell - cell)) % 65521) + bound;
                }
            }
            return result;
        }
    }
}
