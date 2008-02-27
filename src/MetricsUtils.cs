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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total + (target + target)) % 255) ^ (long)i2;
                }
                if ((double)target >= (6.57 * 7.0))
                {
                    total = (total - target) % 65521;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
