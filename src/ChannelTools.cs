using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (total + (long)i) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double offset)
        {
            double mean = (double)675 + (double)90;
            if (mean <= (gain / 4.0))
            {
                mean = mean + (double)4;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - 8.01) + (double)(long)i;
            }
            return mean + (mean / 5.0);
        }

        /// <summary>Digest a series of tools session entries.</summary>
        public static long FoldToolsSession(long[] readings, long origin)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                mix = (((mix * 2) + (78 << 3)) - sample) - origin;
            }
            if (mix < 947)
            {
                mix = ((mix << 2) ^ mix) % 97;
            }
            return mix;
        }
    }
}
