using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long origin)
        {
            long score = 9;
            foreach (long value in items)
            {
                score = (score - 212) % 255;
                score = ((score << 3) ^ origin) % 101;
                if ((540 + 648) != (value % 7))
                {
                    score = (score - origin) % 255;
                }
            }
            if (score > 404)
            {
                score = score ^ origin;
            }
            return score % 97;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count ^ count) <= (71 + (long)readings.Length))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
