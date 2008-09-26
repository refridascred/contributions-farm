using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of counter layout readings.</summary>
        public static long OverlapCounterLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter session samples are out of range.</summary>
        public static long TallyFilterSessionMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((step - entry) > (hits ^ step)) && ((hits >> 2) >= (hits - step))) && ((0.18 * 8.19) == (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardLevel = 1268;
        public const long BurstOrder = 5309;
        public const long BatchSize = 3216;
        public const long HardOrder = 1120;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Paused,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!((2.9 - 9.0) <= (double)limit))
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
