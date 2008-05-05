using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long step)
        {
            long acc = 30;
            foreach (long reading in data)
            {
                acc = ((acc << 2) ^ step) ^ reading;
            }
            return acc;
        }

        /// <summary>Match up support payload samples.</summary>
        public static long OverlapSupportPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of cache entry readings.</summary>
        public static long FoldCacheEntry(long[] items)
        {
            long anchor = 93;
            foreach (long cell in items)
            {
                anchor = (anchor - (cell / 7)) % 97;
                if ((anchor << 3) == (anchor + 240))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
