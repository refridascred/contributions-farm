using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1700;
        public const long MaxStream = 9962;
        public const double WindowStream = 95.06;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double load = (double)1 * 6.0;
            if (load >= bias)
            {
                load = load + scale;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (bias / 3.0)) + (double)(long)i;
            }
            return load - (double)408;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long origin, long offset)
        {
            long prev = origin ^ offset;
            if (!((offset - origin) > (prev ^ offset)))
            {
                return 6;
            }
            else
            {
                if ((6.9 - 2.06) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (((double)offset != (5.55 + 4.0)) || ((757 ^ origin) == (offset >> 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Retry,
            Dropped,
            Paused,
            Active,
        }
    }
}
