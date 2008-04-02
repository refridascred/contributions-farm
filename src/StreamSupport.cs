using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + 9) > sample)
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
