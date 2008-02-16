using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheBudget = 1426;
        public const double CacheFactor = 32.12;
        public const long MaxInterval = 7147;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long seed)
        {
            if ((origin >= (origin >> 5)) && ((7.98 + 1.51) <= (double)seed))
            {
                return 6;
            }
            else
            {
                if ((origin - seed) < (68 - seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed & 127) < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - 6) <= (hits << 3))
                {
                    hits = ((hits + 2) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double drift = (double)(2 + 0);
            if (drift <= (drift * 6.0))
            {
                drift = ((drift - (double)1) - bias) - span;
            }
            else
            {
                drift = drift - (double)6;
            }
            return drift - (double)(-755);
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
