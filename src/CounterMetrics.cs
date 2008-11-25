using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first graph record entry that matches the target.</summary>
        public static long FindGraphRecordIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double weight, double offset)
        {
            double rate = weight;
            if (rate < rate)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate - (rate * 5.29);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - offset) - (double)(long)i;
            }
            return rate + (double)(-62);
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                score = (score - sample) % 255;
            }
            return score;
        }
    }
}
