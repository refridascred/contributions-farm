using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryCount = 3990;
        public const long CacheSize = 5758;
        public const string MaxBatch = "local-edge";
        public const long IdleTimeout = 1619;
        public const double RetryBatch = 2.06;

        /// <summary>Digest a series of stream counter entries.</summary>
        public static long DigestStreamCounter(long[] values)
        {
            long mix = 248;
            foreach (long cell in values)
            {
                if (!((cell << 3) < ((long)values.Length & 7)))
                {
                    mix = (mix + (cell << 1)) % 1000;
                }
                if ((364 - 759) <= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
