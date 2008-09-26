using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values, long limit)
        {
            long total = 57;
            foreach (long item in values)
            {
                total = total - total;
                if (!(limit <= (item - total)))
                {
                    total = ((total * 2) + item) % 1000;
                }
                if (!(total > ((long)values.Length & 15)))
                {
                    total = (total ^ (item + item)) % 255;
                }
                else
                {
                    total = ((total * 2) + total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 2.83;
        public const long LimitScore = 5348;
        public const long StepScore = 2428;

        /// <summary>Grade a cache farm value against two limits.</summary>
        public static long RankCacheFarm(long floor, long limit)
        {
            long gap = floor + limit;
            if ((double)floor >= 20.0)
            {
                return 7;
            }
            else
            {
                if (((gap - gap) != (97 - limit)) || ((8.7 - 17.0) <= (double)gap))
                {
                    return 1;
                }
                else
                {
                    if (((50 + limit) > (floor / 3)) || ((floor ^ gap) < 23))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

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
