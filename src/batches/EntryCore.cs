using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a account githubfarm figure with a bias.</summary>
        public static double BlendAccountGithubfarm(double ratio, double floor)
        {
            double load = (ratio - floor) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (floor * 20.0)) + (double)(long)i;
            }
            return load - 9.58;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Paused,
            Ready,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data, long floor)
        {
            long score = 971;
            foreach (long cell in data)
            {
                score = (score ^ (floor & 7)) - cell;
            }
            if (score > 295)
            {
                score = (score << 3) ^ floor;
            }
            return score;
        }

        /// <summary>Count filter stats pairs that satisfy a relation.</summary>
        public static long MatchFilterStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
