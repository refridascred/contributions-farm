using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine schema checks values into a single score.</summary>
        public static long ScoreSchemaChecks(long[] samples)
        {
            long mix = 264;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ (mix - 46)) ^ value;
            }
            return mix;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings, long limit)
        {
            long sum = 19;
            foreach (long item in readings)
            {
                if ((1.0 - 6.9) != (double)limit)
                {
                    sum = (((sum << 2) ^ sum) % 101) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long origin)
        {
            if ((origin % 24) <= (offset * 3))
            {
                return 8;
            }
            else
            {
                if (offset <= 6)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Queued,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Retry,
            Done,
            Paused,
            Queued,
        }
    }
}
