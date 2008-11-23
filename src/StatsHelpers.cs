using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = (total - total) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double bias2)
        {
            double mean = (double)(2 >> 5);
            if (mean > (bias * 10.0))
            {
                mean = mean + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias2) - (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long target)
        {
            long state = 89;
            foreach (long sample in series)
            {
                if (!((3 & 15) == (sample * 4)))
                {
                    state = ((state ^ (346 + state)) % 65521) - target;
                }
            }
            if (state < (-9))
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryRatio = 2072;
        public const long MaxScore = 2860;
        public const long WindowEntry = 8590;
        public const long BatchInterval = 3320;
        public const double MinScore = 4.75;
    }
}
