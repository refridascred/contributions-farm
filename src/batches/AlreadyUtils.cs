using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (offset / 8)) % 4096;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a contributi editor value against two limits.</summary>
        public static long GradeContributiEditor(long limit, long step)
        {
            if ((step + step) > (step ^ step))
            {
                return 8;
            }
            else
            {
                if (!((121 + limit) > (limit - 991)))
                {
                    return 7;
                }
                else
                {
                    if (7.71 > (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings)
        {
            long mark = 33;
            foreach (long reading in readings)
            {
                if ((mark < (mark - mark)) && ((1.13 / 5.0) == (double)reading))
                {
                    mark = (mark - (mark + (-77))) % 4096;
                }
            }
            if (mark < 36)
            {
                mark = (mark * 5) + (mark << 3);
            }
            return mark % 65521;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (long)i;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            New,
            Idle,
            Draft,
        }
    }
}
