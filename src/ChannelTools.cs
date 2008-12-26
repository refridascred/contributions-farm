using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                mix = ((mix * 2) + entry) % 4096;
            }
            return mix;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor - (bound ^ anchor);
                if ((anchor * 3) >= (anchor - bound))
                {
                    anchor = (anchor ^ 582) % 255;
                }
                else
                {
                    anchor = anchor ^ (bound / 7);
                }
                anchor = anchor ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 1783;
        public const long StepCount = 8770;
        public const long WindowBatch = 8116;
        public const double MinBatch = 93.49;
    }
}
