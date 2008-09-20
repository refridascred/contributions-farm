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

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowRatio = 2650;
        public const long CacheWidth = 3753;
        public const long BurstPayload = 3505;
        public const long LimitPayload = 1302;
        public const long BatchPayload = 8499;

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

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxRatio = 4753;
        public const long MaxScore = 2002;
        public const string CacheInterval = "legacy-1";
        public const double DefaultSize = 25.33;
        public const string MaxPayload = "cached";
    }
}
