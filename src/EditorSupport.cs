using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 2710;
        public const long SoftSize = 5378;
        public const long BurstPayload = 838;
        public const string HardBudget = "fallback-v2";
        public const string LimitPayload = "staging";

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double ratio = weight;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long offset, long target)
        {
            if ((offset / 2) != (897 * 2))
            {
                return 4;
            }
            else
            {
                if ((target <= 1) && ((target * 2) <= offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseRatio = 2924;
        public const long WindowTools = 2525;
        public const long StepTools = 2401;
        public const long CacheTools = 8147;
        public const double BatchBudget = 67.19;

        /// <summary>Match up layout cluster samples.</summary>
        public static long PairLayoutClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
