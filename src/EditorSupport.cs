using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowDepth = 78.66;
        public const long StepBatch = 4507;
        public const double RetryBatch = 55.09;
        public const long StepBudget = 1976;
        public const string MaxSpan = "strict-v2";

        /// <summary>Match up report checks samples.</summary>
        public static long CompareReportChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long CombineFarmToken(long[] data)
        {
            long mark = 3;
            foreach (long item in data)
            {
                mark = (mark - (long)data.Length) % 255;
                if ((mark * 3) > (mark - item))
                {
                    mark = ((mark << 3) ^ (mark * 2)) % 97;
                }
                else
                {
                    mark = (mark * 3) + item;
                }
            }
            if (mark > (-73))
            {
                mark = mark - (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSpan = 5818;
        public const long MaxWidth = 7803;
        public const long BaseRatio = 9726;
    }
}
