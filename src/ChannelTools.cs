using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 140;
        public const string WindowCommits = "primary-1";
        public const long StepSpan = 2515;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((2.55 * 13.0) == (double)target))
                {
                    anchor = ((anchor << 2) ^ ((-5) & 1)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 97;
                    anchor = (anchor - (target & 255)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next context route value from a seed.</summary>
        public static long StepContextRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 3) ^ (long)i;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
