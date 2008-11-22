using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long origin)
        {
            long mix = 3;
            foreach (long reading in series)
            {
                if ((reading << 2) == (reading & 255))
                {
                    mix = ((mix ^ (reading & 15)) % 4096) - origin;
                }
                if (!(85 <= (mix - (long)series.Length)))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 4590;
        public const double BurstCluster = 59.3;
        public const long HardWidth = 7542;
        public const long BaseCluster = 2595;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry + step) > (count << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double scale = (double)62 + offset;
            if (scale < (double)55)
            {
                scale = (scale - (double)697) - weight;
            }
            else
            {
                scale = scale + 1.0;
            }
            return scale - (3.25 - offset);
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 9328;
        public const long LimitWidth = 7410;
        public const double BatchCounter = 57.23;
    }
}
