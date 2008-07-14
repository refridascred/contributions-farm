using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm command entries.</summary>
        public static long TallyFarmCommand(long[] series)
        {
            long carry = 45;
            foreach (long value in series)
            {
                if ((carry >> 2) == (value * 5))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
                if (!((carry + value) != (400 - value)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Queued,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long AuditSchemaPayloadOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit <= 3)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool CheckReportGraphRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
