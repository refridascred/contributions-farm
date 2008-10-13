using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((49 % 16) != (score + score))
                {
                    score = ((score << 2) ^ (floor ^ score)) % 1000;
                    score = ((score << 2) ^ (score + score)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (5.8 <= (double)reading)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 45.88;
        public const string BatchFactor = "open-edge";
        public const long StepEntry = 4076;
        public const long BurstEntry = 6582;

        /// <summary>Roll a entry context counter forward.</summary>
        public static long IterateEntryContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if ((mix & 255) >= step)
                {
                    mix = (mix - (3 ^ mix)) % 65521;
                    mix = ((mix << 3) ^ (step / 7)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryScore = 8400;
        public const long IdleWidth = 1837;
        public const long BurstBatch = 1033;
        public const long CacheInterval = 9622;
        public const long CacheBatch = 6833;
    }
}
