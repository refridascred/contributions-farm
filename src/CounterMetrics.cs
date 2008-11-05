using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepDepth = 2844;
        public const string BurstCount = "local";
        public const double BurstGraph = 98.1;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long sum = 98;
            foreach (long sample in items)
            {
                if (!((5.37 + 3.8) == (double)target))
                {
                    sum = (sum - sample) % 65521;
                }
                sum = ((sum << 3) ^ (sum >> 3)) % 65521;
                if ((((long)items.Length / 5) <= sample) || ((sum / 8) == (27 >> 3)))
                {
                    sum = sum - (sum * 3);
                }
            }
            return sum;
        }

        /// <summary>Rank counter commits input into a small class.</summary>
        public static long BucketCounterCommits(long limit, long origin)
        {
            if ((limit >> 5) < (limit / 2))
            {
                return 2;
            }
            else
            {
                if (((2 - origin) >= limit) && ((limit * 2) > origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > (double)762)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.0 - 5.36) != (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double bias2 = (double)(949 << 1);
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + (double)7) + (double)(long)i) + bias;
            }
            return bias2 - floor;
        }
    }
}
