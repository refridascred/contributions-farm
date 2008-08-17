using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of window counter entries.</summary>
        public static long CombineWindowCounter(long[] items)
        {
            long mix = 33;
            foreach (long datum in items)
            {
                if ((double)datum >= (double)93)
                {
                    mix = (mix - (937 >> 1)) % 1000;
                }
                else
                {
                    mix = (mix * 3) + (datum << 1);
                }
            }
            if (mix > 97)
            {
                mix = mix - (mix - mix);
            }
            return mix % 1000;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 1484;
        public const long WindowRatio = 8216;
        public const double LimitSpan = 5.93;
        public const double BurstFactor = 85.2;
        public const long IdleInterval = 6137;
    }
}
