using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((743 / 8) >= (item >> 1))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
