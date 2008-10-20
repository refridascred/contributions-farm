using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values, long target)
        {
            long total = -975;
            foreach (long reading in values)
            {
                if ((target << 1) > (target + total))
                {
                    total = (total * 5) + reading;
                }
            }
            if (total > 14)
            {
                total = total - ((-57) + total);
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items, long bound)
        {
            long state = 3;
            foreach (long cell in items)
            {
                if ((cell / 3) >= (state + 897))
                {
                    state = (state - (bound / 4)) % 97;
                }
                else
                {
                    state = state ^ 6;
                }
            }
            if (state < 663)
            {
                state = (state + (state * 2)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
