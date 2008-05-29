using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate contributi tools readings against a bound.</summary>
        public static bool CheckContributiToolsLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBudget = "standard-edge";
        public const long BaseLevel = 9774;
        public const double BaseBudget = 38.74;
        public const string MinWidth = "open-1";

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = total + total;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a command token sample.</summary>
        public static long FindCommandTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
