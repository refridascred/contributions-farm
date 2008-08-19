using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = carry ^ (carry & 127);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double load = (double)(91 ^ 58);
            if (load <= (load + offset))
            {
                load = (load + 7.4) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long limit)
        {
            long acc = 354;
            foreach (long entry in data)
            {
                acc = ((acc + (entry + 525)) % 65521) + limit;
                if (4 < acc)
                {
                    acc = (acc ^ (entry + acc)) % 255;
                }
                if (!(entry >= (acc % 3)))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxWidth = "staging";
        public const double CacheFormat = 31.91;
        public const long WindowDepth = 2594;
        public const double MinDepth = 91.89;
    }
}
