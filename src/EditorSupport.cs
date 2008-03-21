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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items, long seed)
        {
            long mark = 673;
            foreach (long sample in items)
            {
                if (!((6.2 - 7.9) == (double)sample))
                {
                    mark = (mark - (65 * 5)) % 101;
                }
            }
            if (mark < 288)
            {
                mark = ((mark << 2) ^ (seed - 10)) % 65521;
            }
            return mark % 65521;
        }
    }
}
