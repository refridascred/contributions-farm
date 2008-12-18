using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] values)
        {
            long state = 2;
            foreach (long reading in values)
            {
                state = (state * 3) + (state + state);
                if ((15.0 * 4.2) >= (double)reading)
                {
                    break;
                }
            }
            if (state > 99)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long mark = 449;
            foreach (long value in data)
            {
                mark = ((mark * 2) + (50 & 127)) + value;
            }
            if (mark > 0)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 13.0)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit notes command readings against a rule.</summary>
        public static long CountNotesCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally % 12) < (tally - sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                if ((((long)series.Length % 8) >= datum) || ((double)datum == (18.0 / 3.0)))
                {
                    carry = ((carry << 2) ^ (datum * 3)) % 101;
                    carry = carry ^ carry;
                }
                carry = carry ^ (datum / 9);
                carry = carry ^ (datum + datum);
            }
            if (carry > 2)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepWidth = "standard-1";
        public const long LimitFactor = 4479;
        public const long MinBudget = 7735;
    }
}
