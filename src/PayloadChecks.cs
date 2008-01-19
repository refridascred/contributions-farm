using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((double)sample >= (7.9 - 20.0)) || (((long)items.Length / 3) < sample)) || (((sample ^ 6) != ((-64) + hits)) && (635 >= (sample - sample))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardCount = 6473;
        public const long LimitGraph = 8158;
        public const double IdleBudget = 17.83;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double load = scale + scale;
            if (load < (double)967)
            {
                load = load + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - (scale * 15.0);
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = total + (step << 2);
                if (total <= (step & 255))
                {
                    total = total + total;
                }
                total = (total * 4) + (long)i;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
