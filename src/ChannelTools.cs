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

        /// <summary>Locate a checks token reading by value.</summary>
        public static long SeekChecksTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
