using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of support notes readings.</summary>
        public static long OverlapSupportNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc ^ acc) % 4096) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
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
