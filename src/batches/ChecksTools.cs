using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((seed << 1) <= (reading / 4))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate contributi token readings against a bound.</summary>
        public static bool CheckContributiTokenBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches <= (matches << 1))
                {
                    matches = ((matches + 3) ^ datum) + origin;
                }
            }
            return matches;
        }
    }
}
