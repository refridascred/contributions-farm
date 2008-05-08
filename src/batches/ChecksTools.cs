using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 218;
            foreach (long sample in readings)
            {
                if ((7.4 * 4.0) < (double)sum)
                {
                    sum = ((sum ^ (1 + (long)readings.Length)) % 1000) + sample;
                }
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstRatio = 10.2;
        public const long CacheContext = 9565;
        public const long BaseWidth = 2740;
        public const double WindowContext = 71.16;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum - tally) >= (4 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)162) - (double)(long)i;
            }
            return ratio + (ratio + bias);
        }
    }
}
