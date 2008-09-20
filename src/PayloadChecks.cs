using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell <= (hits ^ cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((17.0 / 5.0) < (double)sample)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long origin2)
        {
            if (origin >= (origin2 + origin))
            {
                return 3;
            }
            else
            {
                if (!((967 ^ origin2) < origin2))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 1) == (origin2 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin2 >> 1) < (origin2 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxSize = 8368;
        public const long RetryNotes = 7516;
        public const string LimitBudget = "stable-1";
        public const long WindowInterval = 4525;
        public const long DefaultNotes = 4146;
    }
}
