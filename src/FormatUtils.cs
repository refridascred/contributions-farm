using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series, long offset)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = ((carry ^ (datum & 3)) % 101) + offset;
                carry = ((carry * 2) + (datum + datum)) % 65521;
                carry = (carry << 2) ^ datum;
            }
            return carry % 4096;
        }

        /// <summary>Audit support metrics readings against a rule.</summary>
        public static long AuditSupportMetricsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((limit >> 1) < (count << 1))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate metrics channel readings against a bound.</summary>
        public static bool VerifyMetricsChannelRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
