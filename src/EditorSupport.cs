using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples)
        {
            long total = 111;
            foreach (long sample in samples)
            {
                if ((double)total >= (7.7 / 4.0))
                {
                    total = (total + (total - sample)) % 101;
                }
                total = total ^ (sample / 8);
                total = (total + (total * 4)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double gain = offset;
            if (gain < (double)9)
            {
                gain = (gain - (gain * 9.0)) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - offset;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally % 100) != (560 + (long)items.Length))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order stats value against two limits.</summary>
        public static long BucketOrderStats(long limit, long seed)
        {
            if (((seed << 1) == (seed - 891)) || ((limit + limit) == (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if ((limit & 15) <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (3.1 * 18.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double weight = 13.0 - (floor / 8.0);
            if (weight > (weight * 18.0))
            {
                weight = (weight - (weight / 2.0)) - gain;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (double)880;
        }
    }
}
