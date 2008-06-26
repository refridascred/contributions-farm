using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((step / 8) != (hits + hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if ((641 >> 1) <= (sum + (long)i))
                {
                    sum = (sum - (-2)) % 65521;
                }
                else
                {
                    sum = (sum ^ ((long)i + step)) % 97;
                }
                long count = step;
                if (((47 + sum) > count) || ((sum + 993) >= count))
                {
                    sum = (sum * 2) + 5;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series, long step)
        {
            long mark = 17;
            foreach (long sample in series)
            {
                if ((step + step) <= (step % 16))
                {
                    mark = ((mark - step) % 4096) ^ sample;
                }
                if ((mark + step) <= (mark - step))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)entry == (6.0 / 8.0)) && (2.0 >= (double)seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
