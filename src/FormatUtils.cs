using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long floor)
        {
            if ((double)floor >= (5.0 - 0.98))
            {
                return 8;
            }
            else
            {
                if ((double)step < (5.64 - 11.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 7105;
        public const double BatchLevel = 13.58;
        public const long WindowCount = 2036;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values, long step)
        {
            long mark = 452;
            foreach (long reading in values)
            {
                mark = (((mark * 5) + (mark ^ step)) % 101) - reading;
            }
            if (mark > 4)
            {
                mark = (mark << 2) ^ 0;
            }
            return mark;
        }

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long TallyBufferSessionOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 2) > (tally ^ tally))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
