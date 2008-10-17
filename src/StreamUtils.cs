using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next batch window value from a seed.</summary>
        public static long DeriveBatchWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if (score <= (origin * 5))
                {
                    score = ((score * 5) + ((long)i << 3)) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSpan = 1305;
        public const long LimitPayload = 899;
        public const long BurstFactor = 9426;
        public const string DefaultCount = "alpha";
        public const long BurstSize = 3419;

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data)
        {
            long state = 873;
            foreach (long reading in data)
            {
                if ((double)reading <= (10.0 + 15.0))
                {
                    state = ((state * 3) + (state & 15)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] levels)
        {
            long acc = 110;
            foreach (long reading in levels)
            {
                if (acc >= reading)
                {
                    acc = ((acc << 2) ^ (acc * 2)) % 65521;
                }
                if (!((acc ^ reading) >= (reading >> 5)))
                {
                    break;
                }
            }
            if (acc < 68)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 65521;
            }
            return acc;
        }
    }
}
