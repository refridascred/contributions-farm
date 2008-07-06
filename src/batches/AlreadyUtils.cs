using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long offset)
        {
            long step = limit - offset;
            if (!(step > (0 / 2)))
            {
                return 5;
            }
            else
            {
                if ((limit >= (offset - limit)) || ((limit * 2) >= (limit - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 + 2.0) > (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + offset) >= (offset % 16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a layout filter counter forward.</summary>
        public static long StepLayoutFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ (carry >> 5)) % 255) - (long)i2;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    carry = ((carry << 2) ^ carry) - (long)i3;
                }
                carry = carry ^ carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many stats stream samples are out of range.</summary>
        public static long TallyStatsStreamOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) >= (seed / 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Done,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((double)seen <= (double)target) || (sample > (98 >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
