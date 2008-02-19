using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(count < (target % 3)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleCount = 3895;
        public const double LimitBuffer = 68.36;
        public const long HardScore = 7158;
        public const long DefaultFactor = 1912;
        public const string MaxRatio = "primary-v2";

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            New,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry / 6) >= count)
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long offset)
        {
            if (((offset & 3) > offset) && ((0.35 * 9.0) == (double)limit))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (3.4 - 8.3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
