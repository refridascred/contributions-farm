using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits > (63 << 2))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double gain = (double)(72 % 7);
            if (gain <= ratio)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (ratio - bias);
            }
            return gain + (gain - gain);
        }
    }
}
