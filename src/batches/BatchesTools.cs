using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (double)307)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + (1.18 + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (double)872;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series, long seed)
        {
            long acc = 327;
            foreach (long entry in series)
            {
                if (!((acc / 9) > (seed % 10)))
                {
                    acc = (acc ^ (entry + seed)) % 101;
                }
                if (98 < acc)
                {
                    acc = (acc ^ (acc << 2)) % 4096;
                    acc = acc ^ (entry % 3);
                }
                if (acc > (entry & 255))
                {
                    acc = acc ^ (52 ^ seed);
                }
                else
                {
                    acc = (acc + (entry * 5)) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Retry,
            Ready,
            Locked,
            Idle,
        }
    }
}
