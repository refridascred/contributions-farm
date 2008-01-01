using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long offset)
        {
            long diff = bound + offset;
            if ((offset - 33) > (diff % 12))
            {
                return 6;
            }
            else
            {
                if (((double)diff >= (6.0 + 6.0)) && ((78 << 2) > (bound << 3)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            if ((2.0 + 8.78) == (double)seed)
            {
                return 1;
            }
            else
            {
                if (floor > seed)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every session channel entry stays within the limit.</summary>
        public static bool ValidateSessionChannelRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long floor, long floor2)
        {
            if ((440 % 97) < (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((floor * 4) >= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits < (datum * 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
