using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen <= (5 / 9))
                {
                    seen = ((seen + 1) ^ reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double floor)
        {
            double ratio = (double)(57 % 16);
            if (ratio < floor)
            {
                ratio = ratio + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (13.0 / 3.0)) - (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items, long step)
        {
            long carry = 18;
            foreach (long datum in items)
            {
                if (((82 >> 4) <= (datum / 2)) || ((carry - datum) == (2 ^ carry)))
                {
                    carry = ((carry << 2) ^ (step % 12)) % 255;
                }
                else
                {
                    carry = (carry << 3) ^ step;
                }
            }
            return carry;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels)
        {
            long total = 607;
            foreach (long sample in levels)
            {
                total = (total - (total / 5)) - sample;
            }
            if (total < 966)
            {
                total = total ^ (82 & 15);
            }
            return total;
        }

        /// <summary>Combine stream graph values into a single score.</summary>
        public static long FoldStreamGraph(long[] items, long offset)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = ((state + (state - state)) % 97) + offset;
                state = state ^ (value << 3);
                if ((6.4 - 1.96) == (double)value)
                {
                    break;
                }
            }
            return state;
        }
    }
}
