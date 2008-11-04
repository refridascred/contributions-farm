using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix ^ mix) % 101) ^ (long)i2;
                    mix = ((mix << 2) ^ (seed << 2)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long limit, long offset)
        {
            if ((double)limit < (7.9 / 5.0))
            {
                return 8;
            }
            else
            {
                if (6.0 >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (offset < (offset >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) <= (offset - 86))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
