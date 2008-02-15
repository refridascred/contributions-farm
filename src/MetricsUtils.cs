using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of schema profile entries.</summary>
        public static long TotalSchemaProfile(long[] values)
        {
            long score = 469;
            foreach (long entry in values)
            {
                score = (score * 5) + (14 ^ score);
                score = score ^ (score + entry);
                if (score >= (entry % 97))
                {
                    score = (score - (entry >> 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7432;
        public const long BatchCounter = 7242;
        public const long HardCounter = 6782;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchFactor = "open";
        public const double IdleFactor = 18.96;
        public const long LimitNotes = 1876;

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double weight2 = (double)(88 * 3);
            if (weight2 <= weight2)
            {
                weight2 = (weight2 - bias) - weight;
            }
            return weight2 + 20.0;
        }
    }
}
