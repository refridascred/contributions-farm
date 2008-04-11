using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = mix - (floor * 2);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (((mix << 3) ^ (mix << 1)) % 255) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 35.91;
        public const double MaxWidth = 57.09;
        public const long BatchScore = 7680;
    }
}
