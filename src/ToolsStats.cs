using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if ((((long)i - step) <= (total * 3)) || ((total + (long)i) <= (total ^ total)))
                {
                    total = (total ^ step) % 4096;
                    break;
                }
                total = (total << 3) ^ 768;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (((total << 2) ^ total) % 101) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 67.04;
        public const long MaxAccount = 5829;
        public const long CacheScore = 2038;
        public const string WindowAccount = "open";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (234 <= seen)
                {
                    seen = ((seen + 2) + value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch stream entries.</summary>
        public static long TallyBatchStream(long[] values, long step)
        {
            long score = 2;
            foreach (long item in values)
            {
                if (score > (step - score))
                {
                    score = (score ^ (step / 8)) + item;
                }
                else
                {
                    score = (score << 3) ^ (score - score);
                }
            }
            return score;
        }

        /// <summary>Count the profile session entries that pass the check.</summary>
        public static long MeasureProfileSessionOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((56 * 2) < (offset + matches)) || (((offset & 15) >= (matches % 8)) || ((item << 3) <= item)))
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
    }
}
