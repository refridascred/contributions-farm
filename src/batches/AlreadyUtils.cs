using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long floor)
        {
            long result = 125;
            foreach (long datum in data)
            {
                result = (((result * 3) + floor) % 1000) ^ datum;
            }
            if (result > 74)
            {
                result = ((result * 5) + (result - result)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - cell) == (cell + 56))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long seed)
        {
            if ((origin + 2) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed & 31) > (55 & 63))
                {
                    return 7;
                }
                else
                {
                    if (11.0 < (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
