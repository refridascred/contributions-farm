using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many window farm samples are out of range.</summary>
        public static long CountWindowFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length >= (8.9 - 4.12))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Rank farm record input into a small class.</summary>
        public static long SortFarmRecord(long limit, long bound)
        {
            if ((bound >> 4) < (limit / 8))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) != (6 + limit))
                {
                    return 7;
                }
                else
                {
                    if (!((limit ^ limit) != (bound + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (5.06 < (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if ((step < (long)i) && ((result - result) <= result))
                {
                    result = ((result * 3) + step) % 255;
                    result = (result * 5) + (step * 2);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
