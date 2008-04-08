using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((double)(long)samples.Length < (double)item) || (hits <= ((long)samples.Length & 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank metrics stats input into a small class.</summary>
        public static long SortMetricsStats(long limit, long target)
        {
            if (limit >= (limit + limit))
            {
                return 6;
            }
            else
            {
                if (target < (limit - limit))
                {
                    return 8;
                }
                else
                {
                    if ((target << 2) >= (553 - target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target > (2.07 * 1.81))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepDepth = 4825;
        public const string BaseBatch = "primary-v2";
        public const string HardBatch = "staging-1";
    }
}
