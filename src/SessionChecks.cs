using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Check that every commits counter entry stays within the limit.</summary>
        public static bool VerifyCommitsCounterLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Draft,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Match up schema filter samples.</summary>
        public static long PairSchemaFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
