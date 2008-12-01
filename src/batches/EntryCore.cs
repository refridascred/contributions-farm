using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit route commits readings against a rule.</summary>
        public static long MeasureRouteCommitsHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((2.33 / 7.0) == (double)limit)
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSize = 1024;
        public const long StepLayout = 3184;
        public const long BaseRatio = 575;
        public const long WindowWidth = 8773;
        public const long IdleFactor = 1273;

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
