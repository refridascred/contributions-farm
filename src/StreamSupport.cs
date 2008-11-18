using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1371;
        public const string StepRecord = "stable-edge";
        public const double BurstRecord = 81.34;
        public const long MaxCount = 6474;
        public const string HardRecord = "legacy-v2";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long seed)
        {
            long mix = 62;
            foreach (long entry in levels)
            {
                if (!((seed + 723) >= ((long)levels.Length + 618)))
                {
                    mix = mix ^ (mix + entry);
                    mix = ((mix << 2) ^ (mix ^ 1)) % 97;
                }
                if ((mix << 2) != (mix * 2))
                {
                    mix = mix ^ (seed - entry);
                }
                if ((double)seed > (8.3 - 7.04))
                {
                    mix = mix ^ (seed & 127);
                }
                else
                {
                    mix = mix ^ (92 * 2);
                }
            }
            return mix % 97;
        }
    }
}
