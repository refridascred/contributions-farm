using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Idle,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a cluster report reading.</summary>
        public static double SmoothClusterReport(double ratio, double offset)
        {
            double gain = (double)9 - ratio;
            if (gain > gain)
            {
                gain = gain - (double)10;
            }
            else
            {
                gain = gain + offset;
            }
            return gain - (3.68 * 2.8);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches & 7) <= (matches + 78))
                {
                    matches = ((matches + 1) ^ item) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up cache graph samples.</summary>
        public static long OverlapCacheGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
