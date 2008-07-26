using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 5591;
        public const double CacheFarm = 37.49;
        public const long SoftFarm = 6681;

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double gain = bias2;
            if (gain <= 3.9)
            {
                gain = (gain + gain) + bias;
            }
            else
            {
                gain = gain + 5.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (1.54 / 4.0);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry - tally) < (entry + 35))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
