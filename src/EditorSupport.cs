using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] values)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                if (((-65) << 2) > (cell / 2))
                {
                    acc = (acc + cell) % 255;
                }
            }
            return acc;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples, long origin)
        {
            long mark = 32;
            foreach (long item in samples)
            {
                mark = (((mark << 2) ^ (origin + mark)) % 101) + item;
            }
            return mark;
        }

        /// <summary>Roll a metric context counter forward.</summary>
        public static long StepMetricContext(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item ^ 354) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks stats value from a seed.</summary>
        public static long IterateChecksStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - origin) % 4096;
                carry = (carry - carry) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
