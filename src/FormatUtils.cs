using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long offset)
        {
            long edge = seed + offset;
            if (!(edge >= (offset << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)offset != (7.0 - 2.33))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of stats order readings.</summary>
        public static long TallyStatsOrder(long[] samples)
        {
            long result = 0;
            foreach (long sample in samples)
            {
                result = (((result * 5) + (945 << 1)) % 65521) ^ sample;
            }
            return result % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many checks channel samples are out of range.</summary>
        public static long MeasureChecksChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((matches - entry) < (35 + matches)) || ((entry + matches) != (entry ^ entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
