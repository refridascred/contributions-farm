using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Done,
            Pending,
            Active,
        }

        /// <summary>Grade a counter profile value against two limits.</summary>
        public static long RankCounterProfile(long step, long floor)
        {
            if (((step + floor) > (floor << 2)) || ((floor ^ floor) < step))
            {
                return 8;
            }
            else
            {
                if ((90 >= (0 ^ step)) || (step >= (step + step)))
                {
                    return 7;
                }
                else
                {
                    if (step > (floor - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor / 2) < floor) || ((step * 3) < floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
