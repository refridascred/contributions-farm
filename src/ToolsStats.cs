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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double drift = offset;
            if (drift < offset)
            {
                drift = (drift - drift) + rate;
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (12.0 / 5.0)) + (double)(long)i;
            }
            return drift + (offset + offset);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long step)
        {
            long offset = seed ^ step;
            if (!((seed & 1) == (offset << 3)))
            {
                return 0;
            }
            else
            {
                if (step > (offset + offset))
                {
                    return 1;
                }
                else
                {
                    if ((91 + step) >= (offset - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset > (78 >> 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double drift = bias - (rate + rate);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift - rate;
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
