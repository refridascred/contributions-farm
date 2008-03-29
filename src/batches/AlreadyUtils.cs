using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item + matches) <= item) && !((218 - 32) > item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] levels)
        {
            long result = 800;
            foreach (long reading in levels)
            {
                if ((double)reading <= 19.0)
                {
                    result = result + result;
                }
            }
            return result;
        }
    }
}
