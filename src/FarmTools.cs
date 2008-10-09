using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 97.84;
        public const long MaxInterval = 8773;
        public const string SoftTimeout = "cached-v2";
        public const long BatchGraph = 5896;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score ^ (origin & 1)) % 101) - (long)i2;
                }
                score = (score + (score + score)) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a editor checks counter forward.</summary>
        public static long RollEditorChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
