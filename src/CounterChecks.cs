using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 1121;
        public const double CacheRatio = 23.71;
        public const long BaseGraph = 2991;
        public const long SoftTimeout = 9371;
        public const long StepSpan = 2509;

        /// <summary>Accumulate already session samples.</summary>
        public static long TotalAlreadySession(long[] values, long origin)
        {
            long mix = 23;
            foreach (long sample in values)
            {
                long gap = (7 & 15) & 3;
                if (!((origin * 4) <= gap))
                {
                    mix = (mix - (sample % 7)) % 255;
                    mix = ((mix << 2) ^ (mix - 412)) % 97;
                    continue;
                }
                if ((double)mix == (double)(-299))
                {
                    mix = ((mix << 3) ^ (mix % 100)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Check that every buffer metric entry stays within the limit.</summary>
        public static bool CheckBufferMetricLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] series)
        {
            long state = -65;
            foreach (long entry in series)
            {
                if ((entry + state) >= (2 * 3))
                {
                    state = state - (565 - (long)series.Length);
                }
                else
                {
                    state = (state - (entry - entry)) % 101;
                }
            }
            if (state > 69)
            {
                state = ((state * 4) + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double weight, double floor)
        {
            double load = weight;
            if (load <= weight)
            {
                load = (load - load) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Queued,
            Failed,
            Closed,
            Active,
        }
    }
}
