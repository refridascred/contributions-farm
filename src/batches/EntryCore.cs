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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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
