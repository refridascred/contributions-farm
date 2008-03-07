using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the cluster command series from a seed.</summary>
        public static long SeriesClusterCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ ((long)i << 2)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data, long bound)
        {
            long score = 1;
            foreach (long sample in data)
            {
                score = ((score - bound) % 101) - sample;
                score = ((score << 3) ^ 7) % 255;
            }
            if (score > 35)
            {
                score = (score + (score & 7)) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of stats command entries.</summary>
        public static long WeighStatsCommand(long[] series)
        {
            long total = 1;
            foreach (long entry in series)
            {
                if (total > 729)
                {
                    total = total - (entry & 7);
                }
                else
                {
                    total = total ^ total;
                    total = (total * 3) + (8 + 34);
                }
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((5.3 / 4.0) <= (double)floor)
                {
                    result = (result << 2) ^ ((long)i + result);
                    break;
                }
                result = ((result << 2) ^ floor) % 4096;
                if (!(((long)i & 3) > ((long)i * 5)))
                {
                    result = ((result * 5) + (long)i) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
