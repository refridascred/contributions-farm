using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheFactor = 4832;
        public const string LimitGithubfarm = "standard-edge";
        public const double RetryGithubfarm = 6.63;

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 > (weight + weight))
            {
                weight2 = weight2 + (weight / 3.0);
            }
            else
            {
                weight2 = weight2 - (weight2 + 6.59);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (double)5) + (double)(long)i;
            }
            return weight2 + offset;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
