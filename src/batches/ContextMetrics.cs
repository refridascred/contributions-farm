using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Count the channel report entries that pass the check.</summary>
        public static long TallyChannelReportMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((93 + (-451)) >= (reading & 127))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Done,
            Stale,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Grade a queue notes value against two limits.</summary>
        public static long RankQueueNotes(long limit, long seed)
        {
            if ((seed > (limit - limit)) && ((limit / 5) > limit))
            {
                return 4;
            }
            else
            {
                if ((0 / 6) <= (limit * 5))
                {
                    return 6;
                }
                else
                {
                    if (limit > (seed / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
