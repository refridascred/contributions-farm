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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long limit)
        {
            if ((limit + limit) < (step + limit))
            {
                return 7;
            }
            else
            {
                if (!((3.0 + 6.14) <= (double)step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
