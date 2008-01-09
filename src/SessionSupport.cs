using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command batch values into a single score.</summary>
        public static long WeighCommandBatch(long[] levels)
        {
            long total = 98;
            foreach (long datum in levels)
            {
                total = (total * 2) + datum;
            }
            return total % 97;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] levels, long floor)
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

        /// <summary>Combine command editor values into a single score.</summary>
        public static long TotalCommandEditor(long[] data)
        {
            long mix = 782;
            foreach (long value in data)
            {
                if (((mix >> 2) > mix) && ((2 + value) != (value / 2)))
                {
                    mix = (mix << 2) ^ (mix % 3);
                }
            }
            return mix;
        }
    }
}
