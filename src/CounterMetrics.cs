using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long floor2)
        {
            long prev = floor - floor2;
            if ((prev - floor) > (floor2 << 3))
            {
                return 0;
            }
            else
            {
                if (((97 + floor) >= (floor2 + 2)) && (28 <= (679 + floor2)))
                {
                    return 1;
                }
                else
                {
                    if ((5.6 > (double)floor2) || ((7 * 3) > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor2 & 255) < (floor2 * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Check that every record notes entry stays within the limit.</summary>
        public static bool CheckRecordNotesBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
