using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit stats githubfarm readings against a rule.</summary>
        public static long CountStatsGithubfarmMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((long)readings.Length != (offset - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a support batches reading.</summary>
        public static double BlendSupportBatches(double bias, double span)
        {
            double gain = span;
            if (gain < (gain * 0.6))
            {
                gain = (gain - (double)3) + bias;
            }
            return gain + (7.01 + gain);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4087;
        public const double RetrySpan = 35.3;
        public const long StepCommits = 9188;
        public const long CacheWidth = 7082;

        /// <summary>Compare every pair of entry buffer readings.</summary>
        public static long CompareEntryBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a githubfarm metric reading.</summary>
        public static double ScaleGithubfarmMetric(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + gain) - (double)(long)i) - ratio;
            }
            return gain + 3.0;
        }
    }
}
