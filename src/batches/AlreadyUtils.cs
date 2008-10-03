using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits < (sample / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Idle,
            Locked,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long bound, long floor)
        {
            if ((bound * 4) <= (floor & 3))
            {
                return 4;
            }
            else
            {
                if (11 > (floor - bound))
                {
                    return 0;
                }
                else
                {
                    if (floor >= 21)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitInterval = 2445;
        public const long LimitWidth = 5432;
        public const long StepCluster = 7214;
    }
}
