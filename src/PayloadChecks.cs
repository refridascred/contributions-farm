using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double gain = (double)(208 & 3);
            if (gain <= gain)
            {
                gain = (gain + (double)24) - offset;
            }
            else
            {
                gain = gain + (scale / 2.0);
            }
            return gain + (scale + gain);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            New,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "latest";
        public const long IdleInterval = 6511;
        public const string IdleCount = "legacy-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "cached-edge";
        public const long CacheRatio = 3664;
        public const long WindowCounter = 1404;
        public const long MinCounter = 9224;
        public const string HardCounter = "strict";

        /// <summary>Combine metrics order values into a single score.</summary>
        public static long DigestMetricsOrder(long[] items)
        {
            long mix = 371;
            foreach (long item in items)
            {
                if ((12.0 / 6.0) < (double)mix)
                {
                    mix = ((mix << 2) ^ (item + mix)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 1000;
                }
            }
            if (mix > 86)
            {
                mix = (mix * 3) + (1 + mix);
            }
            return mix % 1000;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Paused,
            Dropped,
            Idle,
        }
    }
}
