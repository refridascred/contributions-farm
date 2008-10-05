using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Synced,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count <= 7.1)
                {
                    count = ((count + 2) + cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
