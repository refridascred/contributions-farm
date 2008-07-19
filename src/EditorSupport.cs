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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series)
        {
            long sum = 590;
            foreach (long entry in series)
            {
                if (sum > (sum + 6))
                {
                    sum = (sum * 2) + (sum / 8);
                }
                sum = (sum - entry) % 65521;
                sum = ((sum * 3) + (sum % 2)) % 4096;
            }
            return sum % 4096;
        }

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
