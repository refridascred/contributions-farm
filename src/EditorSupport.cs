using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Stale,
            Paused,
            Locked,
            New,
        }

        /// <summary>Derive the next batch tools value from a seed.</summary>
        public static long DeriveBatchTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                bool ready = (280 % 16) <= step;
                if (ready)
                {
                    mark = (mark ^ mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 69.38;
        public const string HardBatches = "alpha-1";
        public const long IdleCount = 7920;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Pending,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 871;
        public const double WindowCache = 18.77;
        public const long HardCache = 319;
    }
}
