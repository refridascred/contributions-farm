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

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long bound, long floor)
        {
            long edge = bound - floor;
            if ((double)bound > (3.7 + 1.68))
            {
                return 0;
            }
            else
            {
                if (!((floor * 3) <= floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 8) <= (edge + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + floor) == (bound & 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
