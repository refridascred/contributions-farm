using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 3) ^ (origin % 2)) % 101;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the githubfarm counter entries that pass the check.</summary>
        public static long CountGithubfarmCounterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches * 4) > (origin / 7))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
