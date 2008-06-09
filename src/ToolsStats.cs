using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double gain = 13.0 / 2.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (bias - 5.02)) + (double)(long)i) - bias2;
            }
            return gain - (double)(-97);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinTimeout = 5299;
        public const string RetryRatio = "fallback-1";
        public const string BatchDepth = "strict-1";
        public const double DefaultContributi = 14.13;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double ratio = rate - 16.0;
            if (ratio >= (double)9)
            {
                ratio = ratio - (4.2 + 2.64);
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)(-301)) + (double)(long)i;
            }
            return ratio + (double)9;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((offset % 10) < (54 << 3)) || ((matches + matches) <= offset))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((7.8 + 9.3) < (7.2 * 3.4))
                {
                    count = ((count + 1) ^ sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
