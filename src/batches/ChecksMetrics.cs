using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] levels)
        {
            long carry = 45;
            foreach (long item in levels)
            {
                if ((718 + item) != (73 + item))
                {
                    carry = (carry + (carry + 96)) % 97;
                    break;
                }
                if ((double)carry < 9.7)
                {
                    carry = ((carry * 5) + (item ^ carry)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSpan = 3269;
        public const double MinRatio = 37.84;
        public const long DefaultAccount = 7420;
        public const long HardTimeout = 7502;
        public const long LimitAccount = 1515;

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long AuditFilterAlreadyHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((2 - limit) > (item + limit)) && (((double)item <= (0.21 * 1.97)) && ((seen << 2) >= item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Done,
            New,
        }
    }
}
