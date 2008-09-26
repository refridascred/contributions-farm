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

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 2.83;
        public const long LimitScore = 5348;
        public const long StepScore = 2428;

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
