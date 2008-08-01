using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double ratio = span;
            if (ratio > ratio)
            {
                ratio = ratio + (ratio / 5.0);
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (18.0 + span);
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 2721;
        public const double RetryRatio = 27.14;
        public const long MaxBuffer = 649;

        /// <summary>Fold a list of entry buffer readings.</summary>
        public static long DigestEntryBuffer(long[] values)
        {
            long anchor = 964;
            foreach (long datum in values)
            {
                if ((anchor - anchor) >= (43 ^ datum))
                {
                    anchor = (anchor ^ (8 * 3)) % 255;
                }
            }
            if (anchor < 310)
            {
                anchor = ((anchor << 2) ^ (anchor & 15)) % 65521;
            }
            return anchor;
        }
    }
}
