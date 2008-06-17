using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mark = -13;
            foreach (long reading in samples)
            {
                if (!((reading - reading) <= 203))
                {
                    mark = mark - (reading ^ mark);
                }
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark << 2) ^ (74 ^ (long)i);
                }
                if ((13.0 * 3.8) <= (double)reading)
                {
                    mark = (mark - (reading - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items)
        {
            long total = -3;
            foreach (long cell in items)
            {
                if ((0.73 / 7.0) >= (double)total)
                {
                    total = ((total - (58 % 7)) % 97) - cell;
                }
                else
                {
                    total = (total ^ (total - total)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long seed, long floor)
        {
            if ((seed < (floor + floor)) && ((double)floor > (double)seed))
            {
                return 4;
            }
            else
            {
                if ((13 % 97) == (floor >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((floor ^ seed) > (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed <= (412 >> 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                long offset = total;
                total = total - (offset & 31);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
