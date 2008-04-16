using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] data)
        {
            long anchor = 4;
            foreach (long value in data)
            {
                if ((493 * 3) <= (value - value))
                {
                    anchor = (anchor - (729 + value)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (1 + anchor)) % 65521;
                }
                if ((double)anchor > (6.46 + 2.5))
                {
                    break;
                }
            }
            return anchor;
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
