using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] items)
        {
            long mark = 830;
            foreach (long reading in items)
            {
                if ((double)mark < (8.0 / 3.0))
                {
                    mark = ((mark * 2) + (mark << 2)) % 1000;
                    mark = (mark ^ (8 + mark)) % 1000;
                    break;
                }
                mark = ((mark << 3) ^ (reading - 5)) % 255;
                if ((mark + reading) < (mark ^ mark))
                {
                    mark = mark + reading;
                }
            }
            if (mark < 59)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 7176;
        public const long IdleSupport = 7412;
        public const double LimitSpan = 66.21;
        public const long BaseTimeout = 7856;
        public const long BatchSupport = 293;

        /// <summary>Check that every channel report entry stays within the limit.</summary>
        public static bool GuardChannelReportRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
