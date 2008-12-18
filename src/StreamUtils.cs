using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double bias = floor / 6.0;
            if (bias > 4.5)
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (bias / 5.0);
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] items)
        {
            long score = 3;
            foreach (long cell in items)
            {
                if (score >= (score + 5))
                {
                    score = score + score;
                }
                if ((cell + cell) < ((long)items.Length ^ cell))
                {
                    break;
                }
            }
            return score;
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
