using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Queued,
            New,
            Synced,
            Stale,
        }

        /// <summary>Find the first order context entry that matches the target.</summary>
        public static long FindOrderContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order batches pairs that satisfy a relation.</summary>
        public static long PairOrderBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) <= (4 - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 7235;
        public const double RetryInterval = 74.49;
        public const long WindowBudget = 6705;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Draft,
            New,
            Synced,
            Stale,
        }
    }
}
