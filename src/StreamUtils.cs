using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = (total * 5) + limit;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] series)
        {
            long state = 25;
            foreach (long sample in series)
            {
                if ((double)sample >= (double)state)
                {
                    state = ((state << 2) ^ (sample + 8)) % 65521;
                }
                else
                {
                    state = state + (1 + 891);
                }
            }
            if (state < 86)
            {
                state = (state - (state + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Derive the next route cluster value from a seed.</summary>
        public static long SeriesRouteCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + (long)i;
                mark = ((mark * 4) + 86) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Retry,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values, long limit)
        {
            long score = -746;
            foreach (long value in values)
            {
                score = (score ^ (limit % 60)) + value;
            }
            return score;
        }

        /// <summary>Combine batches support values into a single score.</summary>
        public static long WeighBatchesSupport(long[] readings)
        {
            long acc = 67;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (entry - 844)) % 101;
                acc = (acc * 2) + (acc >> 4);
            }
            return acc % 1000;
        }
    }
}
