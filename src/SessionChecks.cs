using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data)
        {
            long acc = 87;
            foreach (long reading in data)
            {
                if (((50 ^ acc) <= (reading - (-9))) || (reading < (acc & 3)))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = acc + (acc - reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long target)
        {
            long bound = seed - target;
            if (!((double)4 >= (double)seed))
            {
                return 1;
            }
            else
            {
                if (((9.0 - 10.0) > (double)bound) && (bound >= (bound - bound)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (2.0 - 9.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
