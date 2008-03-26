using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double drift = (double)41 - (double)4;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + offset) - (double)(long)i;
            }
            return drift + (scale - drift);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 8713;
        public const double WindowTimeout = 63.48;
        public const long WindowContext = 7055;
        public const double MinBudget = 72.25;

        /// <summary>Derive the next order payload value from a seed.</summary>
        public static long SeriesOrderPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (limit >= (87 / 6))
                {
                    acc = ((acc * 5) + (acc * 5)) % 255;
                }
                else
                {
                    acc = acc ^ (acc * 4);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + 655) >= seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
