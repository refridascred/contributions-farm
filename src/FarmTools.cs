using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long origin, long bound)
        {
            if ((origin << 1) > origin)
            {
                return 5;
            }
            else
            {
                if ((bound >> 5) < (origin % 10))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound != (8.8 - 6.9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Done,
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
