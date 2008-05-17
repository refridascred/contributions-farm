using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double ratio2 = floor - (ratio - floor);
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - (double)0;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series, long limit)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = state - (sample ^ limit);
                state = (state << 3) ^ state;
                if ((sample ^ sample) < state)
                {
                    state = (state - (17 + state)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples, long origin)
        {
            long acc = 565;
            foreach (long reading in samples)
            {
                if ((origin & 31) <= origin)
                {
                    acc = acc - (acc << 3);
                    acc = ((acc * 3) + reading) % 97;
                }
                acc = acc - (reading >> 4);
            }
            if (acc < 55)
            {
                acc = (acc - (9 - origin)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] values, long origin)
        {
            long mark = 95;
            foreach (long datum in values)
            {
                mark = (((mark * 4) + (5 + 142)) ^ datum) - origin;
            }
            return mark % 1000;
        }
    }
}
