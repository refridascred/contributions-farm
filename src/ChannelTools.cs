using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the githubfarm session series from a seed.</summary>
        public static long StepGithubfarmSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((state & 3) <= ((long)i << 1))
                {
                    state = state - (120 << 3);
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchInterval = 3823;
        public const double MinCounter = 28.38;
        public const string BurstCounter = "standard-edge";
        public const long IdleCounter = 2097;
        public const string MaxCounter = "alpha-v2";

        /// <summary>Fold a list of layout cache readings.</summary>
        public static long ScoreLayoutCache(long[] series)
        {
            long mix = 831;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((mix + (82 * 2)) % 255) - (long)i;
                    mix = mix ^ (531 + (-9));
                }
                if (((50 - datum) > datum) && ((datum / 7) > (datum % 5)))
                {
                    mix = (mix * 4) + ((-774) ^ mix);
                }
                else
                {
                    mix = (mix ^ (mix - datum)) % 101;
                }
                if ((mix & 63) >= (mix + mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
