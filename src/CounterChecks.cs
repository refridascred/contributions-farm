using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowInterval = 7147;
        public const string WindowCount = "fallback";
        public const double StepDepth = 93.99;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Idle,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long RankChannelChecks(long offset, long seed)
        {
            if (seed <= (offset + offset))
            {
                return 4;
            }
            else
            {
                if (545 > (seed - 29))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 3) == (3 + 28))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit report notes readings against a rule.</summary>
        public static long CountReportNotesMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((0 ^ target) >= (seen ^ 35))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) > 6)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
