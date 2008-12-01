using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits << 3) <= (283 - 815)) && (((-7) + hits) < sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (((mix * 4) + (mix + seed)) % 1000) - (long)i2;
                    mix = mix + (long)i;
                }
                mix = mix + seed;
                mix = (mix * 5) + (mix / 7);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepSpan = "local";
        public const long MinWidth = 9145;
        public const long SoftWidth = 1570;
        public const string LimitChannel = "local-v2";
        public const double BatchScore = 37.82;
    }
}
