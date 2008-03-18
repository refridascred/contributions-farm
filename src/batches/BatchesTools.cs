using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((8.86 / 6.0) < (double)(long)series.Length) || ((seen >= item) || ((double)step <= (double)(long)series.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double scale = (double)(99 % 2);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (bias * 0.1)) + (double)(long)i) - ratio;
            }
            return scale - (scale * 7.0);
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                long tally = (result ^ result) % 64;
                result = result + tally;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
