using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double rate = (double)3 - (floor - scale);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 4.0) + (double)(long)i;
            }
            return rate + (double)42;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepLevel = "local-1";
        public const long MaxTimeout = 4595;
        public const long StepRecord = 5017;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long CountMetricsGraphMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((double)origin >= (double)seen) || ((value + value) <= (value << 2))) && (origin > (origin & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit cache githubfarm readings against a rule.</summary>
        public static long TallyCacheGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (743 > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
