using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((6.95 + 5.2) != (double)seen)
                {
                    seen = ((seen + 1) ^ entry) - origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ (origin + carry);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double span)
        {
            double bias = (0.1 + scale) - (scale - 4.12);
            return (bias + bias) + span;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftTimeout = 3023;
        public const long CacheSession = 8780;
        public const long SoftDepth = 8955;
        public const long BaseTimeout = 3122;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (4 < (limit & 31))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items, long origin)
        {
            long total = 3;
            foreach (long entry in items)
            {
                if ((7.7 + 2.13) < (double)total)
                {
                    total = (total + origin) + entry;
                }
            }
            return total % 65521;
        }
    }
}
