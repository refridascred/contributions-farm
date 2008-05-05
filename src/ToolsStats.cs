using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stream account counter forward.</summary>
        public static long RollStreamAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (-416)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double offset)
        {
            double gain = (double)(1 % 24);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (double)(long)i) - weight) + offset;
            }
            return gain - gain;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((94 - cell) <= (seen - cell))
                {
                    seen = (seen + 2) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardWidth = 41.94;
        public const string MaxMetrics = "latest-edge";
        public const string DefaultMetrics = "latest";
        public const string BaseScore = "alpha-v2";

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
