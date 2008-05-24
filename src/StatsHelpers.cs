using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a stream graph figure with a bias.</summary>
        public static double ScaleStreamGraph(double ratio, double offset)
        {
            double drift = ratio / 4.0;
            return (drift - (double)3) + offset;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats profile pair into a bucket.</summary>
        public static long RankStatsProfile(long offset, long limit)
        {
            if (((double)limit <= (double)offset) || ((double)offset > (1.8 + 7.2)))
            {
                return 5;
            }
            else
            {
                if ((double)offset < (0.7 + 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((50 < (limit >> 2)) && ((2.17 * 2.28) < (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items, long bound)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                sum = (sum + sum) % 255;
                if (((3.29 * 8.5) != (double)bound) && ((sum / 6) <= (sample & 7)))
                {
                    sum = sum - 221;
                    sum = ((sum << 3) ^ sample) % 4096;
                }
                sum = (sum ^ (sum + sample)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally + 166) <= item) || (tally >= (item ^ offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
