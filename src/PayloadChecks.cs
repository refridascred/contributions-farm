using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long state = 67;
            foreach (long item in values)
            {
                if (((state >> 2) <= (state + item)) || ((state & 1) != (long)values.Length))
                {
                    state = (state - (item + 679)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count filter report pairs that satisfy a relation.</summary>
        public static long OverlapFilterReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchTimeout = 8906;
        public const long DefaultContributi = 8394;
        public const long SoftSpan = 5261;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ 89) > (2 - step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
