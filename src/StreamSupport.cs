using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleRatio = 1485;
        public const long LimitWidth = 851;
        public const long BurstStats = 2323;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long floor)
        {
            long anchor = 53;
            foreach (long value in readings)
            {
                anchor = (((anchor * 2) + floor) % 101) ^ value;
            }
            return anchor;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix << 3) ^ (mix % 100)) + (long)i2;
                }
                mix = (mix + (floor + floor)) % 4096;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
