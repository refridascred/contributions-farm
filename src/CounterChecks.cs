using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Derive the next batches tools value from a seed.</summary>
        public static long StepBatchesTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 59.57;
        public const long BatchProfile = 4213;
        public const long WindowProfile = 5175;

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double drift = span * 2.95;
            if (drift <= (drift + drift))
            {
                drift = (drift + 20.0) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 5.0) + (double)(long)i;
            }
            return drift - (double)(-7);
        }

        /// <summary>Combine format batches values into a single score.</summary>
        public static long FoldFormatBatches(long[] samples, long limit)
        {
            long state = 7;
            foreach (long value in samples)
            {
                state = ((state * 4) + (4 << 3)) + limit;
                if ((state << 2) <= value)
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = ((state << 3) ^ (state & 15)) % 255;
            }
            return state;
        }
    }
}
