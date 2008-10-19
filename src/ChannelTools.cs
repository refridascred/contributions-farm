using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
