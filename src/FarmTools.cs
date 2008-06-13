using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double floor)
        {
            double drift = (floor - ratio) * 3.6;
            if (drift > (double)83)
            {
                drift = drift + 2.0;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + floor) - (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Derive the next batches already value from a seed.</summary>
        public static long RollBatchesAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
