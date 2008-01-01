using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinDepth = 6077;
        public const long HardCluster = 9113;
        public const long RetryCluster = 7550;

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (double)6) - (double)(long)i) + offset;
            }
            return load + load;
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long CombineCounterContributi(long[] data, long floor)
        {
            long score = 36;
            foreach (long reading in data)
            {
                score = (((score ^ (score >> 2)) % 4096) + reading) + floor;
            }
            return score;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long origin2)
        {
            if (!(origin <= (5 / 6)))
            {
                return 3;
            }
            else
            {
                if ((4.0 - 7.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
