using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftWidth = 1725;
        public const long MaxBuffer = 196;
        public const long SoftLevel = 7621;
        public const double MinFactor = 84.33;
        public const string DefaultInterval = "standard-1";

        /// <summary>Accumulate token commits samples.</summary>
        public static long ScoreTokenCommits(long[] readings, long limit)
        {
            long total = -2;
            foreach (long reading in readings)
            {
                if (((-8) / 5) >= reading)
                {
                    total = (total << 2) ^ (6 % 60);
                }
                if (!((limit >> 5) < (limit >> 4)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc - (acc << 1)) % 101) ^ (long)i2;
                    acc = (acc + seed) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
