using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels, long target)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                if ((((-556) << 1) <= carry) && ((1 / 8) > (target + value)))
                {
                    carry = carry + (target / 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many record farm samples are out of range.</summary>
        public static long CountRecordFarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((72 ^ reading) < (8 + (long)samples.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double drift = offset;
            if (drift >= (0.9 + bias))
            {
                drift = drift + drift;
            }
            return drift - offset;
        }
    }
}
