using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit >> 1) > (total << 1))
                {
                    total = (total << 3) ^ (44 - 12);
                }
                else
                {
                    total = (total - (total + limit)) % 4096;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a format session pair into a bucket.</summary>
        public static long SortFormatSession(long origin, long offset)
        {
            if (origin < (origin * 4))
            {
                return 2;
            }
            else
            {
                if (origin <= (origin << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= 5.69)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5.25 * 0.9) >= (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metric filter measurements.</summary>
        public static double ScaleMetricFilter(double bias, double floor)
        {
            double mean = (double)(852 + (-658));
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - floor) - (double)(long)i) - bias;
            }
            return mean + (double)49;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 5986;
        public const double HardSize = 66.2;
        public const string DefaultAlready = "primary-1";
    }
}
