using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Failed,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double mean = (double)(483 & 255);
            if (mean < bias)
            {
                mean = (mean - (bias * 2.4)) - ratio;
            }
            return mean + (bias * 1.2);
        }

        /// <summary>Validate cache schema readings against a bound.</summary>
        public static bool GuardCacheSchemaLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
