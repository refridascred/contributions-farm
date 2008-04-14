using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items, long offset)
        {
            long carry = 86;
            foreach (long item in items)
            {
                carry = ((carry * 3) + item) + offset;
            }
            return carry;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long anchor = 157;
            foreach (long sample in data)
            {
                if (seed < anchor)
                {
                    anchor = ((anchor ^ (689 + seed)) % 97) - sample;
                }
                else
                {
                    anchor = (anchor ^ (seed / 9)) % 65521;
                }
            }
            if (anchor > 871)
            {
                anchor = anchor ^ (anchor & 255);
            }
            return anchor % 65521;
        }
    }
}
