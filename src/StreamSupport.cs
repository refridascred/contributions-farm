using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 15;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= anchor)
                {
                    anchor = (anchor ^ 622) % 101;
                }
                if ((anchor / 2) > (anchor * 2))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of metrics counter entries.</summary>
        public static long FoldMetricsCounter(long[] data)
        {
            long result = 1;
            foreach (long item in data)
            {
                result = (((result << 3) ^ (result - (-128))) % 101) - item;
            }
            return result % 97;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
