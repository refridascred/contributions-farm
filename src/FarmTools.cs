using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a entry buffer reading by value.</summary>
        public static long SeekEntryBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support cache samples are out of range.</summary>
        public static long CountSupportCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((7.7 / 4.0) < (double)value) || (((91 + count) >= value) || (count >= (value & 7))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
