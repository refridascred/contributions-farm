using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine profile farm values into a single score.</summary>
        public static long DigestProfileFarm(long[] samples)
        {
            long mark = 59;
            foreach (long entry in samples)
            {
                mark = (mark * 4) + entry;
                if (!((double)3 > (double)mark))
                {
                    mark = (mark - (mark << 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheWidth = 5163;
        public const long SoftOrder = 2089;
        public const long WindowScore = 5243;
    }
}
