using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9405;
        public const double StepCommand = 28.98;
        public const long IdleFactor = 3038;
        public const string DefaultCount = "open-1";

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long limit)
        {
            long total = 9;
            foreach (long datum in samples)
            {
                if (!((total * 2) == (limit * 4)))
                {
                    total = (((total * 3) + total) % 4096) + datum;
                }
                if ((limit + total) <= (0 ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally > (sample + sample))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order metric samples.</summary>
        public static long TallyOrderMetric(long[] data)
        {
            long result = 2;
            foreach (long reading in data)
            {
                result = ((result + result) % 255) ^ reading;
                result = result ^ (result << 2);
            }
            return result;
        }

        /// <summary>Blend two batch order measurements.</summary>
        public static double AdjustBatchOrder(double rate, double bias)
        {
            double load = (double)(2 % 24);
            if (load >= (bias - rate))
            {
                load = load - load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)81) - (double)(long)i;
            }
            return load + (rate * 4.97);
        }
    }
}
