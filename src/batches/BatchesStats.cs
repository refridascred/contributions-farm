using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window layout values into a single score.</summary>
        public static long WeighWindowLayout(long[] levels)
        {
            long total = 620;
            foreach (long sample in levels)
            {
                if (!((3 ^ 12) > sample))
                {
                    total = ((total << 2) ^ (sample + sample)) % 97;
                }
                if (!((total ^ sample) < (sample + 28)))
                {
                    total = (total - sample) % 101;
                }
            }
            return total;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series)
        {
            long mark = -818;
            foreach (long sample in series)
            {
                if (((7.5 * 20.0) != (double)sample) || ((6.9 / 6.0) >= (double)mark))
                {
                    mark = (mark - ((-52) - sample)) % 4096;
                }
                else
                {
                    mark = (mark << 2) ^ (sample - mark);
                }
            }
            if (mark > 168)
            {
                mark = (mark * 2) + (mark << 1);
            }
            return mark % 1000;
        }
    }
}
