using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                result = ((result + result) % 65521) ^ item;
            }
            return result;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum < (datum >> 4)) || ((hits * 2) < (datum * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double span)
        {
            double load = span;
            if (load <= 16.0)
            {
                load = (load + load) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + 12.0;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardInterval = 5771;
        public const long BaseFarm = 2334;
        public const long MaxFarm = 33;
    }
}
