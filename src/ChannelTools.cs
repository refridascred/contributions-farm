using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double rate = floor;
            if (rate >= rate)
            {
                rate = (rate - (double)479) + gain;
            }
            return rate + (rate - floor);
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items, long target)
        {
            long sum = 953;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum * 2) + (datum + target)) % 101) + (long)i;
                }
                if (((datum * 2) < target) || (target > datum))
                {
                    sum = sum ^ (target >> 2);
                }
                sum = (sum ^ (datum * 5)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate already graph samples.</summary>
        public static long WeighAlreadyGraph(long[] items, long limit)
        {
            long total = 971;
            foreach (long sample in items)
            {
                if ((total ^ limit) > limit)
                {
                    total = (((total << 3) ^ limit) % 65521) - sample;
                }
            }
            if (total > 921)
            {
                total = total + 407;
            }
            return total;
        }
    }
}
