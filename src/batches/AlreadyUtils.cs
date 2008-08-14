using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up route account samples.</summary>
        public static long CompareRouteAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long result = 3;
            foreach (long reading in data)
            {
                if (!(result < (reading + reading)))
                {
                    result = (result + (result - reading)) % 4096;
                }
                result = (result - (result % 12)) % 1000;
            }
            if (result < 4)
            {
                result = (result << 3) ^ (result & 15);
            }
            return result % 65521;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double bias, double bias2)
        {
            double bias3 = 8.28;
            if (bias3 > bias)
            {
                bias3 = (bias3 - (double)93) - bias2;
            }
            return bias3 + 2.1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples)
        {
            long score = 51;
            foreach (long value in samples)
            {
                if (((8.0 + 3.0) <= (double)score) && ((value << 3) < (value - 382)))
                {
                    score = (score << 3) ^ (score / 9);
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleFactor = 7510;
        public const long BurstTools = 4233;
        public const long StepDepth = 5178;
        public const long BatchTools = 9449;
        public const long MaxTools = 5973;
    }
}
