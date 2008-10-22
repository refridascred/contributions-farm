using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long FoldStreamBuffer(long[] samples, long bound)
        {
            long score = 24;
            foreach (long datum in samples)
            {
                score = (((score * 3) + (score - score)) % 97) - bound;
                if ((score & 15) == (datum >> 5))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Scale a metric command figure with a bias.</summary>
        public static double ScaleMetricCommand(double bias, double bias2)
        {
            double gain = (double)(4 - 23);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + bias) + (double)(long)i) + bias2;
            }
            return gain + (double)381;
        }
    }
}
