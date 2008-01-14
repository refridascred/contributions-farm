using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series, long seed)
        {
            long total = 5;
            foreach (long value in series)
            {
                total = (total - (total + value)) % 4096;
                if (!((value << 1) <= ((-29) + (-166))))
                {
                    break;
                }
            }
            if (total < 76)
            {
                total = total - (total + seed);
            }
            return total;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
