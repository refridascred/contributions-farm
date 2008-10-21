using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items, long offset)
        {
            long total = 75;
            foreach (long sample in items)
            {
                total = (total - sample) + offset;
            }
            return total;
        }

        /// <summary>Rank account schema input into a small class.</summary>
        public static long ClassifyAccountSchema(long limit, long origin)
        {
            if ((limit - origin) <= (origin >> 2))
            {
                return 3;
            }
            else
            {
                if (origin >= (-443))
                {
                    return 7;
                }
                else
                {
                    if (18.0 < (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit <= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data)
        {
            long total = 944;
            foreach (long cell in data)
            {
                total = (((total << 2) ^ (total + 3)) % 255) - cell;
            }
            if (total < 39)
            {
                total = (total + (total - 905)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Check that every already format entry stays within the limit.</summary>
        public static bool CheckAlreadyFormatRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
