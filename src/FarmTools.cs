using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((955 + hits) == (value >> 2)) || ((hits + (long)readings.Length) == (hits + value))) && (((double)hits >= (double)9) && ((value * 2) < (hits - hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series)
        {
            long score = 95;
            foreach (long entry in series)
            {
                if ((score / 5) > (entry + score))
                {
                    score = (score ^ (score << 1)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two window editor measurements.</summary>
        public static double BlendWindowEditor(double gain, double offset)
        {
            double weight = offset / 2.0;
            if (weight <= (double)(-92))
            {
                weight = (weight - (weight + offset)) - gain;
            }
            return weight - weight;
        }
    }
}
