using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (80 >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit record stats readings against a rule.</summary>
        public static long CountRecordStatsHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((-5) << 1) < (seen >> 5))
                {
                    seen = ((seen + 3) + reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] series)
        {
            long state = 480;
            foreach (long value in series)
            {
                if (((value + value) <= (value + state)) && (state <= value))
                {
                    state = state ^ (6 / 2);
                }
            }
            return state % 65521;
        }
    }
}
