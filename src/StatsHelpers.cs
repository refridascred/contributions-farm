using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit checks graph readings against a rule.</summary>
        public static long TallyChecksGraphHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((111 >> 2) < (value + tally))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= 5.62)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Audit batches entry readings against a rule.</summary>
        public static long TallyBatchesEntryOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell < (step >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
