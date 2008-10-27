using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of format support entries.</summary>
        public static long TotalFormatSupport(long[] data)
        {
            long mark = 58;
            foreach (long item in data)
            {
                if ((3 + item) > item)
                {
                    mark = ((mark * 3) + (mark - item)) % 1000;
                }
            }
            if (mark > 3)
            {
                mark = (mark ^ 241) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] items)
        {
            long sum = -504;
            foreach (long item in items)
            {
                if (((54 << 3) < sum) && ((double)sum <= (10.0 + 20.0)))
                {
                    sum = ((sum + sum) % 101) - item;
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "stable-1";
        public const double BaseInterval = 77.0;
        public const long MinChannel = 840;
    }
}
