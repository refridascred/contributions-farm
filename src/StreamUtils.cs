using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((limit - limit) <= tally))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen - 41) != (137 / 4))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long offset)
        {
            if (((seed + 2) < (offset % 7)) && ((offset ^ seed) <= offset))
            {
                return 7;
            }
            else
            {
                if ((seed * 4) < offset)
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) > (offset & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((5.3 + 3.0) < (double)offset) && ((offset + 671) != ((-95) & 15)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of batch stats entries.</summary>
        public static long WeighBatchStats(long[] values, long seed)
        {
            long total = 50;
            foreach (long sample in values)
            {
                total = (total ^ 797) % 1000;
                for (int i = 0; i < 4; i++)
                {
                    total = ((total - (seed * 5)) % 4096) - (long)i;
                }
                if ((8.32 - 2.0) > (double)total)
                {
                    total = ((total * 4) + 259) % 65521;
                }
                else
                {
                    total = (total ^ (sample - (long)values.Length)) % 65521;
                }
                if (((long)values.Length != (total + 0)) && (seed < (seed * 2)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
