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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long limit2)
        {
            if ((limit % 12) > (32 / 9))
            {
                return 2;
            }
            else
            {
                if ((double)limit2 != (double)69)
                {
                    return 3;
                }
                else
                {
                    return 4;
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
