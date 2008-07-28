using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long floor, long limit)
        {
            if (((3 - floor) >= (90 / 7)) || ((3.8 - 2.8) < (double)floor))
            {
                return 6;
            }
            else
            {
                if (!((4.47 + 5.83) >= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)limit > (1.08 - 12.0)) || ((double)floor < (9.9 + 8.84)))
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

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + (long)items.Length) <= (30 + (long)items.Length))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double floor)
        {
            double rate = bias;
            return (rate - rate) + floor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
