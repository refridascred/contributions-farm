using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the context command series from a seed.</summary>
        public static long IterateContextCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                long count = floor ^ (38 + floor);
                score = (score << 3) ^ (count ^ score);
                score = (score - ((long)i % 16)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a batches record reading.</summary>
        public static double ScaleBatchesRecord(double gain, double offset)
        {
            double rate = gain;
            if (rate <= (double)524)
            {
                rate = rate - (12.0 / 9.0);
            }
            else
            {
                rate = rate + rate;
            }
            return rate - offset;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardRatio = 7441;
        public const double WindowTimeout = 2.73;
        public const long BaseReport = 520;
        public const long RetryInterval = 3393;
    }
}
