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

        /// <summary>Blend two report payload measurements.</summary>
        public static double AdjustReportPayload(double rate, double floor)
        {
            double weight = floor + (double)17;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (rate + rate)) + (double)(long)i;
            }
            return weight - (20.0 - rate);
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double ratio = 1.6;
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio - (double)323) + (double)(long)i) + bias) - bias2;
            }
            return ratio - (ratio * 1.6);
        }
    }
}
