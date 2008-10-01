using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long floor2)
        {
            if (((floor2 - floor2) <= (floor2 + 53)) || (576 <= (floor + floor2)))
            {
                return 7;
            }
            else
            {
                if ((floor << 2) != (floor2 + floor2))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor == (9.6 * 1.89)) && (floor2 <= (floor2 << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor % 2) <= floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long MeasureSessionQueueMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((seed + seed) >= seed) && (seed >= (hits >> 4)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
