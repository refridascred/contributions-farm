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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long mark = -520;
            foreach (long item in levels)
            {
                mark = ((mark ^ ((long)levels.Length * 5)) % 65521) ^ item;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitFactor = 1642;
        public const double IdleFactor = 1.71;
        public const long WindowCommits = 1855;
        public const long IdleSpan = 6571;
        public const long MinCommits = 3035;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Done,
            New,
        }
    }
}
