using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 18.86;
        public const long StepMetrics = 165;
        public const long MinSize = 8188;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally > (double)entry)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 2061;
        public const long BatchLevel = 5836;
        public const long BatchFactor = 5072;
        public const double StepWindow = 22.56;

        /// <summary>Blend two batches queue measurements.</summary>
        public static double SmoothBatchesQueue(double weight, double span)
        {
            double bias = (double)(760 << 3);
            if (bias >= weight)
            {
                bias = bias - span;
            }
            return bias + (span + weight);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSize = 9674;
        public const string CacheBudget = "staging-edge";
        public const long MinFarm = 5118;
        public const long DefaultFactor = 1304;
        public const long BaseRatio = 5983;

        /// <summary>Match up buffer route samples.</summary>
        public static long PairBufferRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
