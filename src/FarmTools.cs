using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long bound)
        {
            if (floor < (bound >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor ^ 201) < floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] samples, long step)
        {
            long mix = 80;
            foreach (long reading in samples)
            {
                mix = ((mix ^ (reading & 15)) % 1000) + step;
                if (((reading << 2) > (reading - 81)) || ((mix - reading) == (reading * 2)))
                {
                    mix = ((mix << 2) ^ (reading >> 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
