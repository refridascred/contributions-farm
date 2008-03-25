using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinFactor = 76.97;
        public const double LimitScore = 92.73;
        public const long MinScore = 1561;

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if (item >= (item * 2))
                {
                    acc = acc + step;
                }
                else
                {
                    acc = ((acc << 2) ^ (9 << 3)) % 255;
                }
            }
            if (acc < 39)
            {
                acc = (acc + (step >> 4)) % 4096;
            }
            return acc;
        }
    }
}
