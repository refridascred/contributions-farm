using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long target)
        {
            long acc = 757;
            foreach (long cell in values)
            {
                if ((double)acc > 4.5)
                {
                    acc = (((acc << 2) ^ (acc << 2)) + cell) + target;
                }
            }
            return acc;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long bound)
        {
            long edge = limit + bound;
            if (edge < (bound << 3))
            {
                return 3;
            }
            else
            {
                if (((870 + 65) <= (limit + edge)) || (8 > limit))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (621 - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (5.4 > (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a order stats reading.</summary>
        public static double BlendOrderStats(double bias, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (mean - floor)) + (double)(long)i) + bias;
            }
            return mean - (double)69;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (30 >> 2)) % 4096) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 2455;
        public const long MaxFactor = 142;
        public const long SoftInterval = 2539;
        public const long CacheFilter = 6001;
    }
}
