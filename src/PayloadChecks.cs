using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + ratio)) + (double)(long)i;
            }
            return load - (bias + ratio);
        }

        /// <summary>Combine order commits values into a single score.</summary>
        public static long DigestOrderCommits(long[] series)
        {
            long total = -59;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (((total * 4) + cell) % 255) ^ (long)i;
                }
                if (((-179) + total) <= total)
                {
                    total = total - (total + total);
                }
            }
            return total;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] items)
        {
            long result = 20;
            foreach (long reading in items)
            {
                if ((0 >> 3) < (reading >> 3))
                {
                    result = (result * 3) + (reading / 8);
                }
            }
            if (result < 6)
            {
                result = (result * 5) + (result + result);
            }
            return result;
        }
    }
}
