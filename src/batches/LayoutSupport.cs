using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4981;
        public const long SoftCommits = 1895;
        public const string IdleCommits = "local";

        /// <summary>Look up the position of a graph channel sample.</summary>
        public static long FindGraphChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels, long origin)
        {
            long carry = 626;
            foreach (long value in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry + ((long)i % 10)) % 1000) - origin;
                }
                carry = carry ^ (value << 3);
                carry = ((carry * 2) + (value - carry)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
