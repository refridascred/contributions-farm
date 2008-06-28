using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit checks stats readings against a rule.</summary>
        public static long CountChecksStatsGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((sample + sample) == (origin - seen)) && ((origin >> 2) <= 1)) && ((double)sample < (4.0 + 6.2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (4 > entry)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
