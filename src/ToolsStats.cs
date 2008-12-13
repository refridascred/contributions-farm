using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a cluster profile figure with a bias.</summary>
        public static double SmoothClusterProfile(double weight, double bias)
        {
            double load = 9.1 + (double)(-5);
            if (load >= (double)18)
            {
                load = (load + (double)23) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) - (double)(long)i;
            }
            return load - (weight + load);
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

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((7.89 * 5.09) > (double)reading)
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
