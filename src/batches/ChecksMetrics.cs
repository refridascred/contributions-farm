using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate entry metric samples.</summary>
        public static long TallyEntryMetric(long[] series, long limit)
        {
            long result = 5;
            foreach (long cell in series)
            {
                if ((double)result <= (3.3 / 4.0))
                {
                    result = ((result * 3) + (result * 4)) % 1000;
                    break;
                }
                else
                {
                    result = (result ^ result) % 65521;
                }
                if ((result / 5) <= cell)
                {
                    result = result + (result / 9);
                }
                else
                {
                    result = (result ^ (limit * 5)) % 255;
                }
            }
            return result;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxFactor = 2674;
        public const long BurstSpan = 25;
        public const long WindowMetrics = 2774;
        public const long BurstCount = 793;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(12 < (entry ^ (long)items.Length)) && (((long)items.Length - step) == (step + entry)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batch batches sample.</summary>
        public static long LocateBatchBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools graph entries.</summary>
        public static long DigestToolsGraph(long[] values)
        {
            long state = 645;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ (sample & 15)) % 1000;
            }
            if (state > 32)
            {
                state = (state + state) % 255;
            }
            return state % 97;
        }
    }
}
