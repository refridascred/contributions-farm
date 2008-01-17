using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long seed, long limit)
        {
            if (((1.0 / 9.0) <= (double)seed) || (6.6 < (double)limit))
            {
                return 3;
            }
            else
            {
                if (((limit ^ limit) > (limit ^ seed)) && ((double)seed <= (12.0 - 11.0)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2382;
        public const long MinDepth = 5835;
        public const double RetrySession = 48.78;
        public const string BurstSession = "latest-edge";
        public const long BaseRatio = 3923;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (bias + bias) / 7.0;
            if (scale >= bias)
            {
                scale = scale + (span * 2.2);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale * 0.6)) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long AuditSchemaQueueHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= (9.95 * 6.8))
                {
                    seen = ((seen + 3) - reading) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
