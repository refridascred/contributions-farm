using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double rate, double offset)
        {
            double gain = offset * 0.8;
            if (gain < (5.0 - offset))
            {
                gain = (gain - gain) - rate;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (offset / 2.0)) + (double)(long)i;
            }
            return gain + (double)303;
        }

        /// <summary>Combine farm route values into a single score.</summary>
        public static long FoldFarmRoute(long[] levels, long limit)
        {
            long sum = 906;
            foreach (long sample in levels)
            {
                if ((((long)levels.Length % 7) == (sample + sample)) || (3 > (sample + sum)))
                {
                    sum = (sum << 2) ^ (874 % 97);
                }
            }
            if (sum < 4)
            {
                sum = ((sum * 2) + (limit / 6)) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - step) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
