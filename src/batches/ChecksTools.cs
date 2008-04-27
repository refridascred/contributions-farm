using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the filter farm series from a seed.</summary>
        public static long DeriveFilterFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc * 2) + limit;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc ^ (acc / 4)) % 101) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long origin)
        {
            if (origin < offset)
            {
                return 5;
            }
            else
            {
                if (((origin & 63) >= origin) || ((origin / 4) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Pending,
            Retry,
            Idle,
        }
    }
}
