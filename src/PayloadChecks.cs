using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batches filter readings.</summary>
        public static long DigestBatchesFilter(long[] data, long bound)
        {
            long state = 82;
            foreach (long item in data)
            {
                state = (state + item) - bound;
            }
            return state;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((bound - entry) != (entry - (long)levels.Length)) && ((double)count == (8.66 + 2.63)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((sample - sample) > (44 % 3)) && (sample >= (sample + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
