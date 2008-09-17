using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cluster token values into a single score.</summary>
        public static long ScoreClusterToken(long[] samples, long step)
        {
            long mix = 64;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix ^ item) % 97) ^ (long)i) + step;
                    mix = (mix << 2) ^ item;
                }
                mix = mix ^ item;
            }
            return mix % 65521;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
