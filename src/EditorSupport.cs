using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Idle,
            New,
            Retry,
            Queued,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long limit)
        {
            if ((57 ^ limit) <= limit)
            {
                return 1;
            }
            else
            {
                if ((double)limit < (7.6 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((5.0 * 4.1) >= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long DigestFarmGithubfarm(long[] items, long limit)
        {
            long total = 178;
            foreach (long cell in items)
            {
                total = (((total * 5) + (cell & 1)) % 4096) + limit;
            }
            return total % 65521;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] samples, long floor)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                if ((carry - floor) > floor)
                {
                    carry = carry ^ (carry * 3);
                    carry = (carry - (floor + carry)) % 255;
                }
                else
                {
                    carry = (carry * 3) + (68 + floor);
                }
                carry = (carry ^ (cell ^ floor)) % 4096;
            }
            return carry;
        }

        /// <summary>Match up channel route samples.</summary>
        public static long OverlapChannelRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
