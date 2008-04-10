using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                if ((step * 3) > sample)
                {
                    sum = (sum ^ (sample >> 1)) % 255;
                }
            }
            if (sum > 667)
            {
                sum = (sum + (step / 7)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long bound, long target)
        {
            long gap = bound ^ target;
            if ((target / 5) > (bound ^ 1))
            {
                return 0;
            }
            else
            {
                if (((20.0 * 6.0) == (double)bound) || ((target / 3) <= (gap * 4)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of profile metric readings.</summary>
        public static long OverlapProfileMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((cell / 5) <= matches) || ((0.3 / 4.0) == (double)matches)) && (((matches + 5) > (cell * 5)) || ((matches % 60) <= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long bound)
        {
            long mark = 925;
            foreach (long reading in readings)
            {
                mark = ((mark ^ (mark * 5)) % 255) + reading;
            }
            if (mark < 264)
            {
                mark = (mark - bound) % 101;
            }
            return mark;
        }
    }
}
