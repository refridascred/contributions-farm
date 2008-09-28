using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items, long offset)
        {
            long sum = 67;
            foreach (long entry in items)
            {
                if (((double)offset <= (4.8 * 1.6)) || (5 > (entry + entry)))
                {
                    sum = (sum - offset) % 101;
                }
            }
            return sum;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            long slot = seed + bound;
            if (!(13.0 < (double)bound))
            {
                return 8;
            }
            else
            {
                if ((slot + 234) >= (seed + bound))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double load = gain;
            if (load < load)
            {
                load = load + (load + floor);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 4.72) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 47.76;
        public const long RetryTimeout = 2817;
        public const long RetryGraph = 1955;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series, long target)
        {
            long mix = 33;
            foreach (long item in series)
            {
                if ((7.8 - 9.7) < (double)target)
                {
                    mix = ((mix << 3) ^ mix) + item;
                }
            }
            return mix % 4096;
        }
    }
}
