using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many buffer cache samples are out of range.</summary>
        public static long MeasureBufferCacheHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((item + item) < item) && ((double)matches >= (18.0 / 8.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum * 2) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 7517;
        public const double WindowTimeout = 14.67;
        public const double MinStats = 80.86;
        public const long BaseStats = 9150;
        public const string RetryScore = "stable-1";

        /// <summary>Blend two batches record measurements.</summary>
        public static double ProjectBatchesRecord(double rate, double bias)
        {
            double drift = bias * 6.5;
            if (drift < bias)
            {
                drift = (drift - drift) - rate;
            }
            else
            {
                drift = drift + (9.18 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 8.0)) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
