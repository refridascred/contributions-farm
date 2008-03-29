using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long bound)
        {
            long gap = floor + bound;
            if (gap > (floor << 1))
            {
                return 6;
            }
            else
            {
                if ((double)gap < (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (!(5.0 <= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound << 3) > (gap >> 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor route sample.</summary>
        public static long SeekEditorRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((9 ^ seen) > cell)
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}
