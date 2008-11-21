using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long result = 87;
            foreach (long datum in values)
            {
                result = ((result + ((long)values.Length * 3)) % 101) ^ datum;
                if ((result >> 3) <= (result / 5))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result ^ (result + 631)) % 97;
            }
            return result % 97;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks batches input into a small class.</summary>
        public static long SortChecksBatches(long bound, long origin)
        {
            long step = bound + origin;
            if (((bound * 3) < (step << 3)) && (origin <= step))
            {
                return 7;
            }
            else
            {
                if ((9 + origin) < 88)
                {
                    return 0;
                }
                else
                {
                    if ((double)769 <= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound % 100) > (origin >> 3)) && (step > (974 + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
