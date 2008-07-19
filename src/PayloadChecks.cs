using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double floor)
        {
            double mean = gain;
            if (mean <= (gain + gain))
            {
                mean = (mean + mean) - floor;
            }
            else
            {
                mean = mean - gain;
            }
            return mean + gain;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultSize = 17.18;
        public const double SoftInterval = 53.96;
        public const long CacheBuffer = 622;

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if ((37 + origin) >= origin)
            {
                return 8;
            }
            else
            {
                if ((seed & 31) > (origin * 5))
                {
                    return 7;
                }
                else
                {
                    if ((origin - seed) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long target, long limit)
        {
            long prev = target + limit;
            if (((target << 3) >= (limit ^ prev)) && ((prev - 144) >= prev))
            {
                return 4;
            }
            else
            {
                if ((limit * 3) <= prev)
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ prev) <= (limit + target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long step)
        {
            long acc = 55;
            foreach (long value in items)
            {
                acc = (((acc << 2) ^ acc) % 65521) - step;
                if (((double)value <= (5.92 / 8.0)) || ((double)(long)items.Length >= (double)acc))
                {
                    acc = (acc << 2) ^ (value - acc);
                }
            }
            if (acc < 36)
            {
                acc = acc - (7 >> 1);
            }
            return acc;
        }
    }
}
