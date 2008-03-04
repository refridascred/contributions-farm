using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every session stream entry stays within the limit.</summary>
        public static bool CheckSessionStreamRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate notes cluster readings against a bound.</summary>
        public static bool CheckNotesClusterRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter tools samples.</summary>
        public static long TallyCounterTools(long[] values, long bound)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if ((double)bound < 3.39)
                {
                    score = ((score * 5) + (bound - bound)) % 255;
                }
                else
                {
                    score = score ^ (reading * 5);
                    score = ((score * 2) + (score + 407)) % 1000;
                }
                if ((double)score >= (10.0 + 4.6))
                {
                    score = ((score << 2) ^ (score * 3)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5222;
        public const long MinStream = 573;
        public const long LimitStream = 4931;
    }
}
