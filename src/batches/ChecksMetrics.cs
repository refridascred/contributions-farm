using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the checks already entries that pass the check.</summary>
        public static long TallyChecksAlreadyOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((((cell ^ cell) < (cell + cell)) || ((count % 60) != (cell / 4))) || ((16.0 * 2.7) > (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftTimeout = 74.13;
        public const double IdleCount = 51.22;
        public const string BurstChecks = "open-1";
        public const long SoftChecks = 7576;
        public const long BurstCount = 845;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long total = 70;
            foreach (long item in items)
            {
                total = ((total * 5) + item) % 4096;
            }
            if (total < 5)
            {
                total = ((total << 3) ^ (limit % 64)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
