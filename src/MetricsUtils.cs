using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long result = 4;
            foreach (long datum in samples)
            {
                if (!((5.9 + 1.2) < (double)datum))
                {
                    result = ((result + (datum << 2)) % 97) - offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)state < (14.0 + 14.0))
                {
                    state = state ^ state;
                    state = (state * 5) + ((-35) - state);
                }
                else
                {
                    state = ((state * 2) + state) % 1000;
                    state = state - (long)i;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 2) ^ ((long)i + seed)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double floor)
        {
            double rate = 19.0 + ratio;
            if (rate < (double)137)
            {
                rate = (rate - (8.0 / 4.0)) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)78) + (double)(long)i;
            }
            return rate - (rate + ratio);
        }
    }
}
