using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series)
        {
            long total = 56;
            foreach (long value in series)
            {
                if ((double)9 == (double)value)
                {
                    total = ((total << 3) ^ (value + 6)) % 255;
                }
                if (782 >= (value - (-20)))
                {
                    break;
                }
            }
            if (total < 33)
            {
                total = (total - (total % 8)) % 65521;
            }
            return total;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels, long offset)
        {
            long anchor = 13;
            foreach (long item in levels)
            {
                if ((offset + offset) < (offset + item))
                {
                    anchor = (anchor * 5) + (offset >> 1);
                }
                if ((offset - offset) > item)
                {
                    break;
                }
            }
            if (anchor > 978)
            {
                anchor = (anchor - (anchor + offset)) % 65521;
            }
            return anchor;
        }
    }
}
