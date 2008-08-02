using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum * 3) > (matches + matches)) && ((datum >> 4) <= ((long)levels.Length * 2)))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowLevel = 51.19;
        public const string IdleCount = "alpha-edge";
        public const long DefaultLevel = 2269;

        /// <summary>Accumulate account commits samples.</summary>
        public static long WeighAccountCommits(long[] samples, long offset)
        {
            long carry = 849;
            foreach (long entry in samples)
            {
                if ((long)samples.Length < (entry >> 2))
                {
                    carry = (carry + offset) % 4096;
                }
                if (((double)entry <= (2.0 + 8.7)) && ((697 - offset) == (offset + carry)))
                {
                    carry = carry ^ ((-6) - entry);
                }
            }
            return carry;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
