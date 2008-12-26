using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if (!((offset2 * 4) > (delta << 2)))
            {
                return 7;
            }
            else
            {
                if (((offset & 127) > (offset + offset2)) && ((delta * 2) > delta))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ (mix % 8)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
