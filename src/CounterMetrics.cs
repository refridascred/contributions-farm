using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((3 + 8) == ((long)i - limit)) || ((limit ^ (long)i) < (-84)))
                {
                    mix = (mix - mix) % 1000;
                }
                if (!(limit <= (mix * 4)))
                {
                    mix = (mix - (limit % 24)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((origin ^ 6) < (hits + origin))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] data, long seed)
        {
            long sum = 14;
            foreach (long entry in data)
            {
                if (((3.73 / 7.0) < (double)entry) || ((6.6 - 6.74) >= (double)sum))
                {
                    sum = (sum * 2) + entry;
                }
                if ((56 >= (seed / 8)) && ((double)entry < (7.6 - 5.4)))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
