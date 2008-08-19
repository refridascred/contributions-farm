using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long MeasureToolsSessionOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (16.0 < (double)tally)
                {
                    tally = ((tally + 3) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((6 ^ hits) <= 4)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
