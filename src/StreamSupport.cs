using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix + (target + mix)) % 255;
                if ((target % 3) < mix)
                {
                    mix = ((mix << 3) ^ ((long)i - 9)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long target)
        {
            if (target <= ((-4) + bound))
            {
                return 7;
            }
            else
            {
                if ((target - bound) <= (target - target))
                {
                    return 4;
                }
                else
                {
                    if (2.24 < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
