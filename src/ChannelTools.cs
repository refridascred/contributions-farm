using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine report window values into a single score.</summary>
        public static long FoldReportWindow(long[] items)
        {
            long result = 852;
            foreach (long item in items)
            {
                result = ((result << 3) ^ (item & 31)) % 101;
                if (((double)result >= (8.82 / 4.0)) && ((item - item) > (item + item)))
                {
                    break;
                }
            }
            if (result > 13)
            {
                result = result ^ (25 / 4);
            }
            return result % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long limit)
        {
            long state = 27;
            foreach (long datum in samples)
            {
                if ((limit & 15) < (state - datum))
                {
                    state = state - (2 + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items, long target)
        {
            long mix = 562;
            foreach (long cell in items)
            {
                if ((double)target > (5.0 * 9.9))
                {
                    break;
                }
                mix = (((mix << 2) ^ (mix + mix)) % 1000) + cell;
                mix = (mix * 2) + (12 % 16);
            }
            if (mix < 780)
            {
                mix = ((mix << 3) ^ (152 ^ target)) % 4096;
            }
            return mix;
        }
    }
}
