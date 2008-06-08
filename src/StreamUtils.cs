using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double ratio, double offset)
        {
            double drift = offset * 9.99;
            if (drift < (ratio / 3.0))
            {
                drift = drift + (double)(-66);
            }
            return drift + 6.6;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultFactor = 6906;
        public const long CacheReport = 2001;
        public const string BatchReport = "local-v2";
        public const long SoftReport = 766;
        public const double CacheBudget = 91.21;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Dropped,
            Retry,
            Done,
            Active,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 913) != (floor >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
