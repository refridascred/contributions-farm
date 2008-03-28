using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long seed)
        {
            if ((seed - 455) <= seed)
            {
                return 6;
            }
            else
            {
                if (!((seed >> 3) < seed))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double rate, double bias)
        {
            double scale = rate * 7.4;
            if (scale <= scale)
            {
                scale = scale + (bias / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values, long target)
        {
            long total = 471;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total + total) % 101) - (long)i;
                }
                if ((sample < total) || ((sample + total) != (total + total)))
                {
                    total = (total ^ target) % 4096;
                }
                else
                {
                    total = total - (sample - total);
                }
            }
            return total;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((51 >> 4) < datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
