using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a entry cluster sample.</summary>
        public static long SeekEntryClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long floor, long target)
        {
            long diff = floor - target;
            if (floor >= (target >> 1))
            {
                return 7;
            }
            else
            {
                if (((target ^ floor) <= floor) && ((double)target >= (0.3 + 5.75)))
                {
                    return 4;
                }
                else
                {
                    if ((8.0 / 3.0) == (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(floor <= diff))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
