using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double offset)
        {
            double gain = (double)33 / 4.0;
            if (gain <= (offset / 7.0))
            {
                gain = gain - gain;
            }
            return gain - scale;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                mark = (mark ^ (mark << 2)) % 1000;
                if ((244 ^ (long)levels.Length) > (mark << 1))
                {
                    mark = ((mark * 3) + (value & 7)) % 255;
                }
                else
                {
                    mark = (mark * 4) + (mark << 2);
                }
            }
            if (mark < 4)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                anchor = (anchor - (anchor - item)) % 101;
                if (anchor > (65 << 1))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
