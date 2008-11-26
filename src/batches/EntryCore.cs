using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)480 >= (double)state))
                {
                    state = ((state << 2) ^ step) % 65521;
                }
                state = (state << 2) ^ (state - state);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Synced,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((datum * 4) > seen) || ((4.3 + 6.6) != (double)datum)) && (datum < (seen - datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up stream batches samples.</summary>
        public static long OverlapStreamBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
