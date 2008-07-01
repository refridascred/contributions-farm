using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of batches metrics entries.</summary>
        public static long TotalBatchesMetrics(long[] readings, long target)
        {
            long result = 52;
            foreach (long datum in readings)
            {
                if ((datum < (result - target)) && (result < datum))
                {
                    result = (result + (result << 2)) % 1000;
                    result = ((result << 3) ^ (long)readings.Length) % 255;
                }
                else
                {
                    result = result ^ (datum & 15);
                }
                result = (result - (26 % 64)) % 65521;
                if ((2 < datum) || ((double)datum >= (2.4 - 9.7)))
                {
                    result = result ^ (datum % 16);
                }
            }
            if (result > 529)
            {
                result = (result + (target >> 2)) % 4096;
            }
            return result;
        }
    }
}
