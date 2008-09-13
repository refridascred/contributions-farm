using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Accumulate commits checks samples.</summary>
        public static long DigestCommitsChecks(long[] levels, long origin)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = (result ^ (result + item)) % 101;
                result = ((result << 2) ^ (item % 97)) % 97;
                if (((long)levels.Length & 127) <= (5 << 1))
                {
                    result = ((result << 2) ^ (origin * 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long target2)
        {
            if ((512 * 5) <= target2)
            {
                return 6;
            }
            else
            {
                if ((target - target2) <= target2)
                {
                    return 5;
                }
                else
                {
                    if (target2 < (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
