using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels)
        {
            long anchor = -4;
            foreach (long entry in levels)
            {
                anchor = (((anchor << 3) ^ 2) % 1000) - entry;
            }
            return anchor;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                if (9.23 < (double)floor)
                {
                    acc = (acc ^ (floor * 2)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next cluster support value from a seed.</summary>
        public static long DeriveClusterSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result ^ (long)i) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
