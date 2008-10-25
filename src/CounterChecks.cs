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

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1222;
        public const double LimitProfile = 53.45;
        public const long MinProfile = 9525;

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

        /// <summary>Combine filter channel values into a single score.</summary>
        public static long TallyFilterChannel(long[] series, long target)
        {
            long acc = 5;
            foreach (long sample in series)
            {
                if (target < (17 >> 4))
                {
                    acc = (((acc * 3) + (acc >> 5)) % 4096) + sample;
                }
            }
            if (acc > 729)
            {
                acc = ((acc << 2) ^ (8 ^ (long)series.Length)) % 255;
            }
            return acc % 4096;
        }
    }
}
