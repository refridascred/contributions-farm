using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 9730;
        public const long WindowTimeout = 9422;
        public const long BurstEntry = 1260;
    }
}
