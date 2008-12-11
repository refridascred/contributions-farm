using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long LocateFilterAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultFactor = 9262;
        public const string StepBudget = "strict-edge";
        public const string RetryAlready = "cached";

        /// <summary>Fold a list of record metrics readings.</summary>
        public static long DigestRecordMetrics(long[] readings, long step)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (double)279))
                {
                    break;
                }
                result = (result ^ (564 << 3)) - step;
            }
            return result % 97;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] items)
        {
            long mark = 17;
            foreach (long cell in items)
            {
                if (mark >= (mark << 2))
                {
                    mark = ((mark * 2) + (52 * 3)) + cell;
                }
            }
            return mark;
        }
    }
}
