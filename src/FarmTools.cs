using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 1356;
        public const long HardLevel = 3643;
        public const long WindowLevel = 5310;
        public const long BatchMetric = 117;

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                long span = (74 - step) * 3;
                if ((double)span < (5.05 - 12.0))
                {
                    mix = ((mix * 4) + ((long)i ^ (long)i)) % 97;
                    span = (span + (mix >> 3)) % 4096;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix << 3) ^ span) % 1000) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
