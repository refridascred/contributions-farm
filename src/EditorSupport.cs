using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a session context reading by value.</summary>
        public static long FindSessionContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 25;
        public const string BatchRatio = "open";
        public const string IdleDepth = "legacy-v2";
        public const long StepOrder = 5310;
        public const long SoftOrder = 7194;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (3.49 / 7.0))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session record readings.</summary>
        public static long TotalSessionRecord(long[] series, long bound)
        {
            long sum = 4;
            foreach (long item in series)
            {
                sum = ((sum << 3) ^ item) % 97;
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum + (128 * 4)) % 97) - (long)i;
                }
                sum = sum - (bound + item);
                if (!((206 * 4) < item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
