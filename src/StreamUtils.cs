using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            if ((target ^ origin) == (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((target / 8) == (origin & 1))
                {
                    return 4;
                }
                else
                {
                    if (origin < (origin + 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin <= (target - 193)) && ((6.1 + 6.18) < (double)target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstLevel = 3769;
        public const long MaxNotes = 7073;
        public const string DefaultNotes = "primary-v2";
        public const long BatchTimeout = 3607;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long step, long target)
        {
            long gap = step + target;
            if (gap < (target % 3))
            {
                return 5;
            }
            else
            {
                if ((double)gap <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (target <= (target + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step / 7) != (915 ^ gap))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
