using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] levels)
        {
            long mix = -311;
            foreach (long reading in levels)
            {
                if ((mix % 8) >= (reading >> 3))
                {
                    continue;
                }
                else
                {
                    mix = (mix * 5) + (81 & 63);
                }
                mix = (mix - (mix + reading)) % 97;
                if (mix > (reading ^ reading))
                {
                    break;
                }
            }
            if (mix > 88)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "standard-edge";
        public const double MaxMetric = 66.49;
        public const long SoftMetric = 958;
        public const long BaseMetric = 1808;

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series)
        {
            long mix = 1;
            foreach (long datum in series)
            {
                if (((datum ^ datum) == (mix - 1)) && ((-55) > (mix - mix)))
                {
                    mix = ((mix * 2) + (29 - datum)) % 4096;
                }
            }
            if (mix > 406)
            {
                mix = mix + (mix * 4);
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Retry,
            Pending,
            Paused,
        }
    }
}
