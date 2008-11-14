using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((((long)i >> 1) < (acc + step)) && ((double)step > 11.0)))
                {
                    acc = (acc ^ (step >> 4)) % 1000;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc + step) % 255) + (long)i2;
                    acc = ((acc << 2) ^ (step / 9)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double weight = (double)(3 % 8);
            if (weight <= gain)
            {
                weight = weight + (weight * 5.0);
            }
            return weight + span;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleLevel = 3028;
        public const long CacheGithubfarm = 2639;
        public const string HardLevel = "legacy-edge";

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepInterval = 63.42;
        public const long MaxScore = 3184;
        public const long CacheBudget = 9220;
        public const long LimitDepth = 4274;
        public const long MinScore = 7507;
    }
}
