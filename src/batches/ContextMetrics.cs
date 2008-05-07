using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double span)
        {
            double mean = span;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (ratio - span)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches < (value % 97))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen / 4) == (seen / 2))
                {
                    seen = ((seen + 3) + value) - seed;
                }
            }
            return seen;
        }
    }
}
