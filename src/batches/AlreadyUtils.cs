using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + 39) != (value & 7))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits - cell) < (cell + hits))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long seed)
        {
            if ((8.39 + 4.0) > (double)target)
            {
                return 4;
            }
            else
            {
                if ((double)seed < (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((seed + seed) < (710 - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target > 2.37)
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

        /// <summary>Digest a series of contributi route entries.</summary>
        public static long TallyContributiRoute(long[] values)
        {
            long state = 66;
            foreach (long cell in values)
            {
                if (state < cell)
                {
                    state = (state * 3) + (923 + 31);
                    state = state ^ (state - cell);
                }
                else
                {
                    state = ((state << 2) ^ (state ^ state)) % 65521;
                }
                if ((cell + state) > (cell / 4))
                {
                    state = (state + (138 >> 5)) % 255;
                }
            }
            if (state < 534)
            {
                state = (state << 2) ^ ((long)values.Length + state);
            }
            return state;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
