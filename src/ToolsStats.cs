using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = -6;
            foreach (long item in values)
            {
                acc = (acc << 3) ^ (21 + item);
            }
            if (acc > (-3))
            {
                acc = acc ^ 7;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchSpan = 93.19;
        public const string BaseFarm = "local";
        public const long WindowFarm = 3669;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = anchor - ((long)i2 + seed);
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
