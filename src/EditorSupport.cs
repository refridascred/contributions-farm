using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Pending,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long item in readings)
            {
                mark = ((mark << 3) ^ (item >> 2)) - offset;
                mark = mark - (item - (-839));
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 711;
        public const string HardScore = "open-edge";
        public const string BaseSession = "latest-edge";

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Dropped,
            Idle,
            New,
            Paused,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 4) + (target + score);
                if ((target / 2) <= (long)i)
                {
                    score = (score + target) % 97;
                    score = (score << 2) ^ (target % 12);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Done,
            Failed,
        }
    }
}
