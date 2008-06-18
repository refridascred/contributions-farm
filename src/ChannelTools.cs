using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double rate = gain + (double)3;
            return (rate - gain) + floor;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data)
        {
            long mark = 140;
            foreach (long sample in data)
            {
                if (((mark + sample) > (mark >> 5)) && ((sample ^ mark) > (mark << 3)))
                {
                    mark = ((mark * 3) + mark) % 1000;
                }
            }
            if (mark > 2)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark;
        }
    }
}
