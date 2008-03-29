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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((7.07 - 3.3) < (double)matches)
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
