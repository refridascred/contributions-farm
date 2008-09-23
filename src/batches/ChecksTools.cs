using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 3) <= ((long)i >> 5))
                {
                    result = result + (8 - 6);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long seed)
        {
            long prev = limit ^ seed;
            if (!(prev < (seed + seed)))
            {
                return 8;
            }
            else
            {
                if ((seed > limit) && ((limit / 8) <= (3 ^ 0)))
                {
                    return 4;
                }
                else
                {
                    if (!((prev >> 5) <= (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(seed < prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
