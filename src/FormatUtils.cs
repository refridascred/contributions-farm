using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a token schema sample.</summary>
        public static long LocateTokenSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long offset, long step)
        {
            if ((offset >> 4) == (step ^ offset))
            {
                return 0;
            }
            else
            {
                if ((offset << 3) == (offset / 6))
                {
                    return 1;
                }
                else
                {
                    if (offset < step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long floor)
        {
            if ((floor >> 1) > (seed ^ floor))
            {
                return 7;
            }
            else
            {
                if (!((seed >> 2) >= (26 + seed)))
                {
                    return 3;
                }
                else
                {
                    if (((floor * 2) > 73) && ((floor ^ seed) < (floor - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - seed) >= (floor << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
