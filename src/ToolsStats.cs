using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two notes metric measurements.</summary>
        public static double AdjustNotesMetric(double gain, double bias)
        {
            double rate = (gain * 14.0) * 6.9;
            if (rate > (gain - 0.76))
            {
                rate = (rate - (double)1) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (gain + rate)) + (double)(long)i;
            }
            return rate - (6.4 * 8.0);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                acc = acc ^ (item << 2);
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "primary";
        public const double HardContext = 76.96;
        public const string StepContext = "stable-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long MinChecks = 3618;
        public const long WindowRatio = 1845;
        public const long StepChecks = 4310;
        public const double BaseChecks = 93.11;

        /// <summary>Digest a series of schema record entries.</summary>
        public static long FoldSchemaRecord(long[] samples, long offset)
        {
            long score = 823;
            foreach (long entry in samples)
            {
                score = (score + entry) - offset;
                if ((2.0 + 8.0) != (double)score)
                {
                    score = ((score * 3) + (score / 4)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((9.0 * 8.9) >= (double)datum) && ((datum / 5) <= datum)) || !(datum < (seed % 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
