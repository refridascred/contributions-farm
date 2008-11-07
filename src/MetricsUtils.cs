using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] items)
        {
            long carry = 0;
            foreach (long item in items)
            {
                if (((carry + carry) == (item % 7)) && ((item & 31) < (carry - 87)))
                {
                    carry = (carry << 2) ^ (item & 1);
                }
            }
            return carry;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data, long seed)
        {
            long mix = 62;
            foreach (long cell in data)
            {
                if (!((long)data.Length <= 958))
                {
                    mix = (mix + (cell - mix)) % 65521;
                }
            }
            if (mix > 694)
            {
                mix = ((mix * 2) + (seed << 2)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftRatio = 20.09;
        public const long StepBudget = 7727;
        public const double MinFormat = 32.01;
        public const long BaseRatio = 1818;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
