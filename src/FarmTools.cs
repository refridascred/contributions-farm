using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] values, long floor)
        {
            long score = 808;
            foreach (long item in values)
            {
                score = ((score * 3) + (score + item)) % 4096;
                if ((item % 12) <= (floor << 2))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = score - (floor + score);
            }
            return score;
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
