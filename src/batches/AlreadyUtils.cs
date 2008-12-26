using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first format payload entry that matches the target.</summary>
        public static long LookupFormatPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSpan = 166;
        public const long RetryDepth = 3770;
        public const long IdleRatio = 9029;
        public const string IdleLevel = "cached";

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item * 3) > (count ^ item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
