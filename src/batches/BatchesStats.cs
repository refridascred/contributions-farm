using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(count >= (86 + datum)) || ((datum <= (datum & 127)) || (count <= (count ^ count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate payload batches readings against a bound.</summary>
        public static bool GuardPayloadBatchesRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 - (double)9) - bias;
            }
            return bias2 - (floor * 18.0);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series, long offset)
        {
            long acc = -863;
            foreach (long datum in series)
            {
                if ((offset >> 4) > (246 - offset))
                {
                    acc = ((acc << 3) ^ acc) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 4096;
                }
                if ((datum + 9) < datum)
                {
                    acc = acc + acc;
                }
            }
            if (acc > 818)
            {
                acc = (acc << 3) ^ offset;
            }
            return acc % 65521;
        }
    }
}
