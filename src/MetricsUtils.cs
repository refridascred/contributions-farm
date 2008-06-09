using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "primary";
        public const string RetryScore = "staging-edge";
        public const long StepBudget = 2274;
        public const long BatchQueue = 3507;

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 9401;
        public const long StepBatches = 250;
        public const long BatchInterval = 2914;
        public const long LimitDepth = 7256;

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values)
        {
            long acc = 18;
            foreach (long cell in values)
            {
                if ((cell - acc) != (cell + acc))
                {
                    acc = acc ^ cell;
                }
            }
            if (acc > 201)
            {
                acc = acc + (acc - 0);
            }
            return acc % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally + sample) != (sample - 7)) || (tally >= 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
