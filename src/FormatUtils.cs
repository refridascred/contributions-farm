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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark << 3) ^ (mark >> 3)) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
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
