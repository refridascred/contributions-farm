using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinWidth = 87.32;
        public const long LimitMetric = 5377;
        public const long BatchTimeout = 2627;
        public const long BaseMetric = 8116;
        public const long SoftMetric = 7012;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double load = floor * 5.1;
            if (load <= (weight + floor))
            {
                load = load - (double)52;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.9) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Classify a counter metric pair into a bucket.</summary>
        public static long GradeCounterMetric(long target, long origin)
        {
            if (((3.24 + 3.78) >= (double)origin) && (origin > (206 / 9)))
            {
                return 8;
            }
            else
            {
                if (((origin & 7) > origin) || ((origin % 97) > origin))
                {
                    return 1;
                }
                else
                {
                    if (target <= (origin % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin + target) < origin) && (10.0 >= (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i >= (step + 66))
                {
                    acc = ((acc << 2) ^ (acc / 4)) % 255;
                    acc = (acc * 3) + (7 & 255);
                }
                else
                {
                    acc = acc ^ acc;
                }
                if ((acc ^ acc) > step)
                {
                    long prev = step - (acc ^ acc);
                    acc = acc - prev;
                }
                else
                {
                    acc = ((acc << 2) ^ step) % 65521;
                }
                acc = (acc - acc) % 1000;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
