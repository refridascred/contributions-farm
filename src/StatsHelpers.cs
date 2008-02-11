using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                mix = mix ^ (441 ^ datum);
            }
            return mix;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings)
        {
            long result = 6;
            foreach (long sample in readings)
            {
                result = ((result << 3) ^ (result << 1)) % 255;
                if (sample > (result + (long)readings.Length))
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = (result ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long total = 262;
            foreach (long datum in readings)
            {
                if ((datum * 3) > (733 >> 2))
                {
                    total = total + (total + total);
                    break;
                }
                if (!((datum & 15) <= (datum - datum)))
                {
                    total = total - 303;
                }
            }
            if (total > 84)
            {
                total = ((total * 2) + total) % 4096;
            }
            return total;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
