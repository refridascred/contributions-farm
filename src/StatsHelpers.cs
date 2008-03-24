using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a window channel reading by value.</summary>
        public static long SeekWindowChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long offset)
        {
            if ((offset << 2) > (45 >> 4))
            {
                return 4;
            }
            else
            {
                if (((offset + bound) <= (bound ^ 70)) && (offset <= (offset - bound)))
                {
                    return 8;
                }
                else
                {
                    if (((offset % 24) != (53 + 226)) || ((bound - bound) > (4 & 255)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset / 7) <= (bound % 12))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a report order reading by value.</summary>
        public static long LookupReportOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
