using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count commits layout pairs that satisfy a relation.</summary>
        public static long OverlapCommitsLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)offset)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long step, long seed)
        {
            if ((seed / 6) < (step << 1))
            {
                return 4;
            }
            else
            {
                if (((seed & 31) != (288 % 100)) || ((seed - seed) == (seed + 3)))
                {
                    return 3;
                }
                else
                {
                    if (step > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
