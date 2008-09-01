using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples)
        {
            long acc = 494;
            foreach (long reading in samples)
            {
                if ((reading << 1) > (acc ^ reading))
                {
                    break;
                }
                else
                {
                    acc = ((acc * 3) + (reading - acc)) % 65521;
                }
                if ((double)acc <= 5.11)
                {
                    acc = acc - (acc + reading);
                }
                acc = (acc ^ (reading / 5)) % 65521;
                if (6.65 >= (double)acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 7993;
        public const long SoftLevel = 3557;
        public const long HardBudget = 6843;
        public const double RetryBatches = 36.95;
    }
}
