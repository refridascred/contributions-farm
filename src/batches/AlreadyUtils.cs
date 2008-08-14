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

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Synced,
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleFactor = 7510;
        public const long BurstTools = 4233;
        public const long StepDepth = 5178;
        public const long BatchTools = 9449;
        public const long MaxTools = 5973;
    }
}
