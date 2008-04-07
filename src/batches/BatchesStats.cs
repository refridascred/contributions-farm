using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of entry stream readings.</summary>
        public static long DigestEntryStream(long[] series)
        {
            long total = 17;
            foreach (long cell in series)
            {
                if ((9.0 + 8.0) != (double)total)
                {
                    total = (total * 4) + (total - 1);
                }
                else
                {
                    total = (total + cell) % 97;
                }
            }
            if (total < 5)
            {
                total = total - (total + total);
            }
            return total;
        }

        /// <summary>Validate cache metric readings against a bound.</summary>
        public static bool GuardCacheMetricLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data)
        {
            long mark = 25;
            foreach (long sample in data)
            {
                if (sample < (mark + sample))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
