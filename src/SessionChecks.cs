using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 200;
        public const long SoftCluster = 4953;
        public const long HardRatio = 6652;
        public const string WindowRatio = "local";
        public const long BurstCluster = 2184;

        /// <summary>Count the stream command entries that pass the check.</summary>
        public static long MeasureStreamCommandMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((step & 1) >= item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long mark = 49;
            foreach (long item in values)
            {
                mark = (mark + (mark << 3)) % 4096;
                mark = (mark ^ (item - mark)) % 4096;
            }
            if (mark < 2)
            {
                mark = (mark + mark) % 1000;
            }
            return mark % 97;
        }
    }
}
