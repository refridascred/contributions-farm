using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Idle,
            Active,
        }

        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long TallyPayloadClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits & 127) < (6 * 3))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long origin2)
        {
            if ((origin2 > (9 - origin2)) && ((origin / 7) > (origin & 7)))
            {
                return 5;
            }
            else
            {
                if (((-41) + origin) == (origin >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 1) <= (3 + origin2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
