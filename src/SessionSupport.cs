using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits * 4) >= (target - target))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ (mix % 97);
                mix = (mix - (floor * 5)) % 97;
                if (((long)i + mix) <= (mix & 15))
                {
                    mix = ((mix * 4) + (mix >> 5)) % 101;
                }
                else
                {
                    mix = mix ^ (mix ^ 72);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
