using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((step % 10) > entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length <= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long TallyChecksLayoutGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)target >= (1.0 * 2.89))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long origin, long origin2)
        {
            if ((origin2 + origin) <= origin2)
            {
                return 0;
            }
            else
            {
                if ((443 * 4) != (origin2 << 1))
                {
                    return 2;
                }
                else
                {
                    if ((2 & 7) >= (origin2 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.69 + 5.36) != (double)origin)
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

        /// <summary>Validate checks batch readings against a bound.</summary>
        public static bool ValidateChecksBatchBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
