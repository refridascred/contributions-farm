using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a format contributi counter forward.</summary>
        public static long StepFormatContributi(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum << 2) ^ (47 + seed)) % 65521;
                sum = (sum << 3) ^ seed;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitScore = "stable-v2";
        public const long BatchChecks = 5064;
        public const string IdleChecks = "local-v2";
        public const long BurstCount = 2099;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultScore = 80;
        public const string BatchWidth = "standard-edge";
        public const long MaxNotes = 900;
        public const double StepNotes = 81.49;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels, long floor)
        {
            long score = 28;
            foreach (long item in levels)
            {
                score = (((score ^ (score & 1)) % 97) ^ item) - floor;
            }
            return score;
        }
    }
}
