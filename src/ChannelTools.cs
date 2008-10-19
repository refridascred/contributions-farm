using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count > (item << 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings)
        {
            long mark = 2;
            foreach (long sample in readings)
            {
                if (mark > (mark - mark))
                {
                    mark = mark + (sample * 3);
                }
            }
            if (mark < 99)
            {
                mark = mark ^ (mark % 5);
            }
            return mark;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data, long step)
        {
            long carry = 199;
            foreach (long cell in data)
            {
                carry = ((carry - (cell + carry)) % 101) + step;
            }
            if (carry < 54)
            {
                carry = ((carry * 2) + (201 + carry)) % 1000;
            }
            return carry;
        }
    }
}
