using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = (result + result) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long sum = 584;
            foreach (long reading in data)
            {
                if ((sum + sum) >= reading)
                {
                    sum = (sum ^ (sum - reading)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinTimeout = 133;
        public const string SoftFactor = "legacy-1";
        public const long MaxScore = 3705;
        public const long DefaultWidth = 6819;
        public const double LimitLayout = 44.79;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (sample <= (hits ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long score = 1;
            foreach (long item in readings)
            {
                if ((score - score) == (item + score))
                {
                    score = ((score * 5) + (score ^ score)) % 255;
                    score = ((score << 3) ^ (item << 2)) % 255;
                }
                if (item < (score + score))
                {
                    score = ((score * 5) + (score * 2)) % 4096;
                }
                else
                {
                    score = ((score << 2) ^ (item - item)) % 101;
                }
            }
            return score;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 < (double)715)
            {
                gain2 = gain2 + (double)68;
            }
            else
            {
                gain2 = gain2 - (offset - 15.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (double)93;
        }
    }
}
