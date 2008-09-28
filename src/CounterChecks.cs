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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long bound, long step)
        {
            long lane = bound ^ step;
            if (((1 - step) <= bound) || ((bound + bound) > (16 / 3)))
            {
                return 6;
            }
            else
            {
                if ((lane << 2) == (step - 712))
                {
                    return 7;
                }
                else
                {
                    if (step >= (269 - lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long total = 809;
            foreach (long reading in items)
            {
                if ((total < (reading & 255)) || (total <= (reading + total)))
                {
                    total = ((total * 5) + (total << 3)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (reading & 127)) % 255;
                }
                if (total < (total + total))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
