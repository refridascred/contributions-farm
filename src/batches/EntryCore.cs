using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 75.35;
        public const long BurstCount = 4770;
        public const double HardDepth = 23.0;
        public const long LimitEntry = 7387;
        public const long BaseWidth = 8398;

        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long TallyGraphChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((3.8 / 2.0) >= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long target)
        {
            if (!((0 % 8) == (target * 2)))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (16.0 - 5.4))
                {
                    return 0;
                }
                else
                {
                    if ((limit - target) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of stream githubfarm entries.</summary>
        public static long TotalStreamGithubfarm(long[] series, long offset)
        {
            long acc = 5;
            foreach (long value in series)
            {
                acc = (((acc * 5) + 812) % 1000) ^ value;
                if ((double)offset > (double)192)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
