using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Locked,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Measure how many schema farm samples are out of range.</summary>
        public static long MeasureSchemaFarmGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((708 <= ((long)values.Length + count)) || ((step ^ sample) > 444))
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheInterval = 2140;
        public const long BurstScore = 6901;
        public const long RetryFactor = 9966;
        public const long BurstWidth = 2179;
        public const long RetryStats = 4270;
    }
}
