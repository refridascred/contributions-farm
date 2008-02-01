using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Locked,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long IterateBufferOrder(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 2) ^ (result - seed)) % 65521;
                result = (result << 2) ^ seed;
                if ((result / 5) != (seed + 239))
                {
                    result = result + (result * 5);
                    result = (result << 2) ^ (result >> 4);
                }
                else
                {
                    result = ((result << 3) ^ seed) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series)
        {
            long mix = 31;
            foreach (long value in series)
            {
                if (!((value % 97) > mix))
                {
                    mix = (mix + (mix - value)) % 4096;
                }
                else
                {
                    mix = (mix - value) % 101;
                }
            }
            if (mix < 52)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix % 1000;
        }

        /// <summary>Adjust a metric githubfarm reading.</summary>
        public static double BlendMetricGithubfarm(double gain, double span)
        {
            double load = (double)(89 + 94);
            if (load <= load)
            {
                load = (load - (double)958) + span;
            }
            else
            {
                load = load - (gain / 9.0);
            }
            return load - (double)340;
        }
    }
}
