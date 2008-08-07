using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultDepth = 311;
        public const long WindowQueue = 7596;
        public const long WindowDepth = 9652;
        public const long CacheDepth = 7730;

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] data)
        {
            long mix = 400;
            foreach (long reading in data)
            {
                if (9 >= (mix + reading))
                {
                    break;
                }
                mix = mix + (reading + mix);
            }
            if (mix < (-31))
            {
                mix = ((mix << 2) ^ (mix << 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + acc) - (long)i2;
                }
                acc = ((acc * 3) + (seed + (long)i)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxCount = "primary";
        public const long DefaultWidth = 2061;
        public const long MaxLayout = 9641;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
