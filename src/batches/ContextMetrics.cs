using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next route filter value from a seed.</summary>
        public static long DeriveRouteFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor * 5) + (long)i;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the githubfarm counter entries that pass the check.</summary>
        public static long TallyGithubfarmCounterHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample ^ 87) >= (sample + sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
