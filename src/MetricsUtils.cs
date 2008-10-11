using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the support buffer entries that pass the check.</summary>
        public static long MeasureSupportBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((double)datum > (double)747) || ((matches * 4) >= datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryDepth = 46.74;
        public const long HardCount = 342;
        public const string HardFormat = "latest";
        public const double CacheFormat = 37.29;

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = total ^ (total + datum);
                if (datum >= (total - total))
                {
                    continue;
                }
                total = total ^ (total + total);
            }
            if (total > 666)
            {
                total = (total ^ target) % 101;
            }
            return total;
        }
    }
}
