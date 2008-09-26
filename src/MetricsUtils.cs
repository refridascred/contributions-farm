using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mark = 975;
            foreach (long value in samples)
            {
                mark = (mark - (value & 1)) % 65521;
            }
            if (mark > (-692))
            {
                mark = mark - (mark >> 1);
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of token stream readings.</summary>
        public static long CompareTokenStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 5227;
        public const long DefaultFactor = 4747;
        public const double MinTimeout = 37.61;
        public const long BatchDepth = 6053;

        /// <summary>Rank record profile input into a small class.</summary>
        public static long BucketRecordProfile(long bound, long step)
        {
            long bound2 = bound + step;
            if (2.0 <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 4) > (bound2 % 64))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (bound % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
