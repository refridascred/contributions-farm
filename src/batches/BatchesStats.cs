using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long floor)
        {
            if ((308 <= (floor + floor)) && ((bound + bound) != (bound + floor)))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) < (bound % 12))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound <= (0.86 - 7.3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((12.0 - 5.26) == (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long floor, long seed)
        {
            long slot = floor + seed;
            if ((floor * 2) <= slot)
            {
                return 2;
            }
            else
            {
                if (((551 - slot) <= slot) || ((seed + slot) >= (-46)))
                {
                    return 4;
                }
                else
                {
                    if (floor >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
