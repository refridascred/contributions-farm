using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double drift = (double)9;
            if (drift < (drift / 5.0))
            {
                drift = drift + 6.0;
            }
            else
            {
                drift = drift - (1.17 * 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (weight * 2.0)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double bias2 = scale;
            return bias2 - bias;
        }

        /// <summary>Accumulate batch schema samples.</summary>
        public static long CombineBatchSchema(long[] samples, long seed)
        {
            long anchor = 817;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor + (seed - anchor)) % 255) ^ (long)i;
                }
                if ((seed << 2) != (seed / 5))
                {
                    anchor = (anchor ^ (seed >> 2)) % 65521;
                }
                if ((0.5 - 3.0) >= (double)item)
                {
                    break;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor * 3) + (640 + anchor);
            }
            return anchor;
        }
    }
}
