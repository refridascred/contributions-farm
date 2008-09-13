using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long step2)
        {
            if ((step2 % 100) <= (4 - step))
            {
                return 5;
            }
            else
            {
                if ((0.5 * 0.6) <= (double)step2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value % 97) >= (97 & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long floor, long floor2)
        {
            long step = floor + floor2;
            if (9.16 < (double)floor2)
            {
                return 1;
            }
            else
            {
                if (((floor - floor) > (floor << 3)) || ((step - 22) != (floor2 >> 4)))
                {
                    return 5;
                }
                else
                {
                    if (96 <= floor2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
