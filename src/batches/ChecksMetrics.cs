using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                if (89 < (acc - seed))
                {
                    acc = (acc + ((-70) + acc)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] values, long bound)
        {
            long mix = 98;
            foreach (long entry in values)
            {
                mix = ((((mix * 3) + (7 >> 5)) % 255) - entry) - bound;
            }
            return mix;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) != (hits + hits))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result << 2) ^ (749 >> 3)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryWidth = 2037;
        public const string BurstFactor = "primary";
        public const long StepScore = 4788;
        public const double BatchSpan = 54.83;
        public const long WindowStream = 5392;
    }
}
