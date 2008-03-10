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

        /// <summary>Scale a context command figure with a bias.</summary>
        public static double ScaleContextCommand(double scale, double bias)
        {
            double weight = bias + scale;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)1) - (double)(long)i;
            }
            return weight - (double)24;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryScore = 66.42;
        public const string BurstWidth = "staging-1";
        public const long MinSpan = 5439;
        public const double LimitMetrics = 77.09;
        public const string BatchMetrics = "stable-edge";

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value * 3) < value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                if ((reading >> 5) == (247 - (long)data.Length))
                {
                    acc = (acc ^ (7 >> 2)) % 1000;
                }
            }
            if (acc > 891)
            {
                acc = (acc - acc) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
