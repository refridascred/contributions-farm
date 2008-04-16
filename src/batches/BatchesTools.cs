using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] readings)
        {
            long mix = 91;
            foreach (long datum in readings)
            {
                mix = ((mix * 3) + (datum - datum)) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > (rate2 + rate))
            {
                rate2 = rate2 - (floor / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ (mix / 3)) % 4096) + reading;
            }
            return mix % 4096;
        }
    }
}
