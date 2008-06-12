using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 33.22;
        public const long CacheLayout = 3585;
        public const long BatchLayout = 478;
        public const long CacheFactor = 2485;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum + datum) <= (datum + (long)readings.Length)) || ((double)count <= (double)30))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double mean = (double)(59 / 2);
            if (mean > 0.7)
            {
                mean = ((mean + mean) - ratio) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean + mean)) - (double)(long)i;
            }
            return mean - (mean - 5.0);
        }
    }
}
