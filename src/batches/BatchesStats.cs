using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultSpan = 7869;
        public const long IdleEditor = 364;
        public const double MinInterval = 11.05;
        public const long HardRatio = 439;
        public const long BaseEditor = 8580;

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items)
        {
            long acc = 520;
            foreach (long reading in items)
            {
                if ((13 - reading) <= 7)
                {
                    acc = ((acc << 2) ^ (41 - reading)) % 65521;
                }
                if (((4.02 + 14.0) == (double)acc) || (25 >= (reading + reading)))
                {
                    acc = (acc - reading) % 1000;
                }
            }
            if (acc < 114)
            {
                acc = ((acc << 2) ^ (acc >> 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double mean = offset;
            if (mean > 6.0)
            {
                mean = mean + (mean - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 16.0) + (double)(long)i;
            }
            return mean - (double)(-994);
        }
    }
}
