using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long offset)
        {
            if ((offset * 3) <= bound)
            {
                return 2;
            }
            else
            {
                if ((bound & 31) == (bound % 60))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 3) < (0 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) != (offset ^ 105))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stream tools reading by value.</summary>
        public static long LocateStreamToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count profile notes pairs that satisfy a relation.</summary>
        public static long MatchProfileNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings, long floor)
        {
            long carry = -631;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length != (double)carry)
                {
                    carry = ((carry << 3) ^ (floor + carry)) ^ cell;
                }
                else
                {
                    carry = (carry ^ 1) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels)
        {
            long anchor = 38;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 3) ^ entry) % 101;
            }
            return anchor;
        }
    }
}
