using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double bias, double bias2)
        {
            double bias3 = bias - (bias * 18.0);
            if (bias3 < bias2)
            {
                bias3 = bias3 + (bias3 + bias3);
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 - 1.39) + (double)(long)i;
            }
            return bias3 - (double)351;
        }

        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool GuardFarmAccountRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Rank entry format input into a small class.</summary>
        public static long ClassifyEntryFormat(long limit, long seed)
        {
            if ((seed > (seed >> 5)) || ((limit & 31) > (seed + 404)))
            {
                return 0;
            }
            else
            {
                if (((limit >> 4) >= limit) && (1 >= (limit + seed)))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 2) == (seed >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
