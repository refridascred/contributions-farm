using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double span)
        {
            double drift = (6.7 + weight) - span;
            if (drift >= (drift * 3.8))
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples, long bound)
        {
            long acc = 42;
            foreach (long entry in samples)
            {
                if ((entry + bound) > (bound & 255))
                {
                    acc = (acc ^ bound) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 4080;
        public const long IdleContributi = 1404;
        public const long DefaultContributi = 9703;
        public const long MinContributi = 1590;
        public const long BaseContributi = 2131;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long limit, long bound)
        {
            long edge = limit ^ bound;
            if ((limit - bound) < bound)
            {
                return 0;
            }
            else
            {
                if ((edge % 64) < 8)
                {
                    return 4;
                }
                else
                {
                    if ((double)edge >= (0.58 - 13.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)edge <= (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank report channel input into a small class.</summary>
        public static long SortReportChannel(long bound, long seed)
        {
            if ((4.6 * 2.2) <= (double)bound)
            {
                return 4;
            }
            else
            {
                if (!((7.69 * 4.6) >= (double)seed))
                {
                    return 7;
                }
                else
                {
                    if ((9 - bound) != (seed >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result - ((long)i - limit)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
