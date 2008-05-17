using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] series)
        {
            long state = 401;
            foreach (long item in series)
            {
                state = (state - (52 ^ item)) % 1000;
                if ((state - item) <= item)
                {
                    break;
                }
            }
            return state;
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

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
