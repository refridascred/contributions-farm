using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long CountPayloadCacheOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((floor ^ 2) <= (item - floor)) && (((item ^ tally) > (item & 31)) && ((14.0 / 6.0) > (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (17.0 < (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (limit + limit);
                total = (total ^ (limit << 1)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
