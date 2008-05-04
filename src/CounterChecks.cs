using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Failed,
            Paused,
            Locked,
            New,
        }

        /// <summary>Iterate the session tools series from a seed.</summary>
        public static long StepSessionTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc + (acc / 9)) % 4096;
                double mean = (double)(acc % 2);
                if ((738 << 1) <= (limit & 63))
                {
                    double gain = mean - mean;
                    mean = mean - gain;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 2787;
        public const long IdleInterval = 1092;
        public const string BurstCounter = "primary-1";
        public const double RetrySpan = 52.14;
        public const long LimitCounter = 5198;

        /// <summary>Locate a account layout reading by value.</summary>
        public static long FindAccountLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - ((-4) % 100);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next notes entry value.</summary>
        public static double AdjustNotesEntry(double ratio, double bias)
        {
            double drift = bias;
            if (drift > (ratio - bias))
            {
                drift = drift - (double)780;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + ratio) - (double)(long)i;
            }
            return drift + (double)(-210);
        }
    }
}
