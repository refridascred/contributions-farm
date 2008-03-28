using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Draft,
            Synced,
        }

        /// <summary>Look up the position of a token batch sample.</summary>
        public static long LocateTokenBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long target)
        {
            if ((9.0 / 4.0) <= (double)target)
            {
                return 3;
            }
            else
            {
                if (target <= (target % 7))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long AuditSchemaLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + count) > (count >> 1))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Idle,
            Queued,
        }
    }
}
