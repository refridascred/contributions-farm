using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the graph stream series from a seed.</summary>
        public static long StepGraphStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((904 * 4) >= (bound * 2))
                {
                    anchor = (anchor - (anchor - bound)) % 255;
                    anchor = ((anchor * 5) + (58 % 24)) % 97;
                }
                else
                {
                    anchor = ((anchor * 5) + ((long)i ^ anchor)) % 101;
                }
                if (bound <= (anchor * 5))
                {
                    anchor = ((anchor * 4) + (anchor ^ bound)) % 4096;
                    anchor = (anchor - (14 / 9)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)count < (0.38 / 7.0)))
                {
                    count = ((count + 3) + datum) + floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long state = 2;
            foreach (long item in samples)
            {
                if ((((-2) ^ 0) > item) && ((double)2 >= (double)item))
                {
                    state = state + 836;
                }
            }
            return state;
        }
    }
}
