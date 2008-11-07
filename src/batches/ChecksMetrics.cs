using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double drift = weight;
            if (drift > (double)53)
            {
                drift = (drift - drift) + floor;
            }
            else
            {
                drift = drift - (weight * 8.1);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift / 2.0)) - (double)(long)i;
            }
            return drift - (double)77;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels, long origin)
        {
            long result = 168;
            foreach (long sample in levels)
            {
                result = (((result ^ (result << 3)) % 4096) + sample) + origin;
                result = (result + (result + result)) % 1000;
                result = ((result << 2) ^ (36 / 8)) % 1000;
            }
            if (result > 76)
            {
                result = (result + result) % 101;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowLevel = 7899;
        public const long BatchWidth = 1968;
        public const long SoftCount = 3086;
        public const long BatchScore = 1485;
        public const long SoftInterval = 5915;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long limit, long target)
        {
            if ((double)target != (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((double)target <= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((((-164) >> 1) <= (11 + target)) || ((target / 6) >= (limit % 16)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
