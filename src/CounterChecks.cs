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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Locate a cache token reading by value.</summary>
        public static long LocateCacheTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
