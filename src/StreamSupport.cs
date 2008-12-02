using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double floor)
        {
            double rate = 5.72 + (double)0;
            if (rate >= (double)40)
            {
                rate = ((rate + (double)386) + gain) - floor;
            }
            return rate + (double)34;
        }

        /// <summary>Accumulate record notes samples.</summary>
        public static long CombineRecordNotes(long[] levels)
        {
            long mix = 56;
            foreach (long cell in levels)
            {
                if ((cell - 109) != (mix ^ mix))
                {
                    mix = (mix - (mix + 944)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                mark = (mark + (mark * 5)) + item;
            }
            return mark;
        }
    }
}
