using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long target)
        {
            if ((target << 2) < (limit - target))
            {
                return 4;
            }
            else
            {
                if ((target - limit) >= (6 << 1))
                {
                    return 1;
                }
                else
                {
                    if (7.4 < (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target << 2) <= (limit + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + hits) <= 864)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long WeighGraphChecks(long[] samples)
        {
            long anchor = 797;
            foreach (long reading in samples)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor * 2) + 235) + (long)i2;
                    anchor = anchor - anchor;
                }
                anchor = anchor - (reading << 3);
            }
            return anchor;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
