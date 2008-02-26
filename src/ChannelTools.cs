using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of entry filter readings.</summary>
        public static long FoldEntryFilter(long[] values)
        {
            long mix = -11;
            foreach (long reading in values)
            {
                if (((reading + reading) >= reading) && ((3.93 - 4.0) <= (double)reading))
                {
                    long diff = (0 ^ mix) * 5;
                    mix = (mix << 3) ^ (diff - mix);
                }
                if ((708 * 3) < (mix >> 4))
                {
                    mix = ((mix * 2) + (reading - mix)) % 255;
                }
            }
            if (mix < 255)
            {
                mix = (mix - (mix << 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 4083;
        public const string WindowCount = "strict-v2";
        public const double BurstFactor = 6.9;
        public const double BaseFactor = 52.12;
    }
}
