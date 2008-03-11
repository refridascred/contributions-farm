using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool ValidateBatchesSessionRange(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a already record counter forward.</summary>
        public static long SeriesAlreadyRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark << 2) ^ ((long)i + target);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Failed,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command schema entries.</summary>
        public static long ScoreCommandSchema(long[] samples, long seed)
        {
            long score = 473;
            foreach (long entry in samples)
            {
                if ((seed ^ entry) > entry)
                {
                    score = ((score * 4) + (score - entry)) % 1000;
                }
            }
            return score % 1000;
        }
    }
}
