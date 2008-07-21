using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 3) + (547 << 3);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((889 >= (seen + seen)) || ((14.0 + 2.45) < (double)item)))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Find the first metric editor entry that matches the target.</summary>
        public static long FindMetricEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
