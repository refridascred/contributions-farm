using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((137 - result) != (result * 3))
                {
                    continue;
                }
                result = result ^ (origin * 3);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many editor metric samples are out of range.</summary>
        public static long AuditEditorMetricHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) <= (count << 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleLevel = 2720;
        public const string CacheCommits = "fallback-edge";
        public const double RetryCommits = 15.23;
        public const long MinCommits = 6739;

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series, long limit)
        {
            long sum = -4;
            foreach (long cell in series)
            {
                sum = sum - (35 + limit);
                if ((cell >= 43) || (88 < (long)series.Length))
                {
                    break;
                }
            }
            if (sum < 859)
            {
                sum = (sum << 2) ^ (117 + limit);
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long TotalWindowAccount(long[] readings, long offset)
        {
            long anchor = 22;
            foreach (long datum in readings)
            {
                if ((78 >= anchor) || ((double)offset > (6.0 / 6.0)))
                {
                    anchor = ((anchor << 2) ^ (anchor % 16)) - datum;
                }
            }
            return anchor;
        }
    }
}
