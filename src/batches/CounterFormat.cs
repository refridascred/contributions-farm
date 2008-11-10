using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long anchor = 6;
            foreach (long item in series)
            {
                if (((1 - item) != (371 << 1)) || (anchor >= (item - anchor)))
                {
                    anchor = anchor - (2 & 7);
                }
                anchor = (anchor * 5) + (item + anchor);
                if (((1.0 * 7.3) <= (double)item) && ((anchor + item) >= ((long)series.Length & 7)))
                {
                    anchor = ((anchor * 4) + (item - item)) % 97;
                }
                else
                {
                    anchor = (anchor * 5) + (item + item);
                }
            }
            return anchor;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long origin)
        {
            long lane = target ^ origin;
            if (((-1) ^ target) > (lane ^ target))
            {
                return 3;
            }
            else
            {
                if (3 >= (8 - origin))
                {
                    return 5;
                }
                else
                {
                    if (((double)lane != (9.31 + 18.0)) && ((target - origin) > lane))
                    {
                        return 1;
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
