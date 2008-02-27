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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long bound)
        {
            long span = target ^ bound;
            if (span >= (9 << 2))
            {
                return 8;
            }
            else
            {
                if ((3.9 + 9.0) <= (double)span)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
