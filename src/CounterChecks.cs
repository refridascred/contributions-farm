using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of support profile readings.</summary>
        public static long FoldSupportProfile(long[] values)
        {
            long state = 72;
            foreach (long sample in values)
            {
                if ((state - sample) > 2)
                {
                    state = (state + (6 + sample)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally > 15.0)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            if (limit <= (limit << 1))
            {
                return 8;
            }
            else
            {
                if ((limit + step) > limit)
                {
                    return 6;
                }
                else
                {
                    if (!((limit - step) <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((limit > (limit & 63)) || ((1.7 / 4.0) != (double)cur))
            {
                return 0;
            }
            else
            {
                if ((limit - cur) >= limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
