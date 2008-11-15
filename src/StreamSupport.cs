using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double mean = 0.36;
            if (mean <= (mean / 5.0))
            {
                mean = ((mean + mean) - ratio) - floor;
            }
            else
            {
                mean = mean - 5.7;
            }
            return mean + 7.4;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((hits - cell) > (-68)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
