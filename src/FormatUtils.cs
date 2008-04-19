using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series, long origin)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if ((origin - 3) <= (entry & 63))
                {
                    sum = sum + 7;
                }
                else
                {
                    sum = sum ^ (entry ^ entry);
                }
                if (!((double)entry < (double)2))
                {
                    break;
                }
            }
            if (sum > 376)
            {
                sum = ((sum << 2) ^ (origin % 3)) % 255;
            }
            return sum;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 3.46;
        public const long SoftBudget = 8066;
        public const double HardTimeout = 91.46;

        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((88 / 7) >= (cell % 97))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
