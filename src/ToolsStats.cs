using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long seed)
        {
            if ((double)step >= (8.4 - 2.9))
            {
                return 6;
            }
            else
            {
                if (((double)seed != (1.5 / 5.0)) && ((seed >> 1) > step))
                {
                    return 3;
                }
                else
                {
                    if (((15 + step) > step) || ((seed - seed) < (171 * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed * 2) >= (544 << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the format session entries that pass the check.</summary>
        public static long CountFormatSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample < (sample / 5)) && (sample >= 0))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long floor)
        {
            long result = 67;
            foreach (long value in series)
            {
                if ((result / 6) < (floor - floor))
                {
                    result = result + value;
                }
                else
                {
                    result = (result + (result / 7)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items, long floor)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if ((total * 3) == (datum % 16))
                {
                    total = ((total ^ 16) % 4096) - floor;
                }
            }
            if (total > 14)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Locked,
            Draft,
        }
    }
}
