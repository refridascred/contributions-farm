using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long mark = -523;
            foreach (long entry in series)
            {
                if ((entry * 2) < (entry + 535))
                {
                    mark = mark - (entry + mark);
                }
                mark = (mark ^ (mark + 58)) % 65521;
                if (((-24) ^ mark) != (mark & 1))
                {
                    mark = (mark - (3 / 9)) % 255;
                }
            }
            if (mark > 605)
            {
                mark = (mark ^ 3) % 65521;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSpan = 3455;
        public const string MinAlready = "latest";
        public const string HardWidth = "legacy-1";
        public const double BaseSpan = 35.08;
        public const double DefaultAlready = 74.34;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
