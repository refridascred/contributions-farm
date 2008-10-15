using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the order route series from a seed.</summary>
        public static long DeriveOrderRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = total + (total ^ seed);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm stats readings.</summary>
        public static long MatchGithubfarmStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] values)
        {
            long result = 63;
            foreach (long datum in values)
            {
                if (datum >= (datum - result))
                {
                    result = ((result << 3) ^ result) % 97;
                }
            }
            return result;
        }

        /// <summary>Derive the next queue channel value from a seed.</summary>
        public static long StepQueueChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((double)mix >= (double)origin) || (9 >= (310 + mix)))
                {
                    mix = ((mix << 2) ^ origin) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Paused,
            Synced,
        }
    }
}
