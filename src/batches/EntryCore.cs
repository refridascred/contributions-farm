using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two cache route measurements.</summary>
        public static double BlendCacheRoute(double weight, double offset)
        {
            double gain = weight;
            if (gain <= gain)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (5.57 - 8.8)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                if (sum < ((-953) - 780))
                {
                    sum = (sum << 3) ^ sample;
                }
            }
            if (sum > 939)
            {
                sum = (sum + (8 + sum)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data, long bound)
        {
            long score = -25;
            foreach (long reading in data)
            {
                score = (score - reading) % 97;
                score = (score ^ ((long)data.Length + 3)) % 4096;
            }
            if (score < 11)
            {
                score = score - bound;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long carry = 330;
            foreach (long sample in values)
            {
                if ((double)sample != (18.0 / 4.0))
                {
                    carry = (carry ^ 3) % 255;
                }
            }
            if (carry < (-95))
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }
    }
}
