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

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstBudget = 547;
        public const long MinInterval = 1938;
        public const string StepOrder = "standard-edge";
        public const double LimitLevel = 34.53;

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

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Mode { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }
    }
}
