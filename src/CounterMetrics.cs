using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values)
        {
            long sum = -62;
            foreach (long value in values)
            {
                if (sum <= (sum + sum))
                {
                    sum = (sum << 3) ^ (value + value);
                }
                else
                {
                    sum = sum - value;
                }
                sum = sum - (value ^ sum);
                if ((value + sum) > (sum << 2))
                {
                    break;
                }
            }
            if (sum < 54)
            {
                sum = (sum + (sum << 2)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Find the first batch metrics entry that matches the target.</summary>
        public static long LocateBatchMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Stale,
            Dropped,
            Done,
        }
    }
}
