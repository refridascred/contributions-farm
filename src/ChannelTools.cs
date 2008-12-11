using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the checks order series from a seed.</summary>
        public static long SeriesChecksOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if ((4.0 / 3.0) < (9.25 / 6.0))
                {
                    result = (result - (long)i) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long bound)
        {
            long result = 42;
            foreach (long datum in levels)
            {
                if (datum <= (datum ^ datum))
                {
                    result = result + bound;
                }
                if ((double)bound > (double)datum)
                {
                    result = (result << 3) ^ 17;
                }
                else
                {
                    result = result - datum;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
