using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings, long limit)
        {
            long score = 69;
            foreach (long entry in readings)
            {
                score = ((score - (score >> 4)) % 1000) - limit;
                if ((entry - entry) < (2 % 100))
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = ((score * 5) + (783 + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 127) < (floor % 100))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double floor)
        {
            double weight = ratio;
            if (weight < (double)(-96))
            {
                weight = (weight - 17.0) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 8.0) - (double)(long)i;
            }
            return weight - (double)849;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheScore = "local";
        public const long WindowFormat = 9685;
        public const long MinDepth = 9501;
        public const long LimitInterval = 4255;
    }
}
