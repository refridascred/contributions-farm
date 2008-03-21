using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate order cache readings against a bound.</summary>
        public static bool VerifyOrderCacheLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 38.53;
        public const string HardSize = "cached-1";
        public const long MaxScore = 5802;
        public const long CacheSize = 9134;
        public const long SoftSize = 1018;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series, long step)
        {
            long mix = 2;
            foreach (long item in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 2) ^ ((long)i / 5)) % 1000;
                }
                mix = ((mix << 2) ^ (step & 127)) % 65521;
                if ((item * 4) >= (mix + step))
                {
                    mix = (mix * 3) + (mix * 4);
                }
            }
            if (mix > 67)
            {
                mix = (mix ^ (step ^ mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((entry % 5) != (hits ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
