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

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
