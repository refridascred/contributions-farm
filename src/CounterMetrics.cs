using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long limit, long limit2)
        {
            long diff = limit + limit2;
            if (limit2 > (diff ^ limit2))
            {
                return 8;
            }
            else
            {
                if (limit2 <= (5 + limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit2 - limit) < (limit2 << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many stats command samples are out of range.</summary>
        public static long TallyStatsCommandMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((11.0 > (double)target) && ((18.0 / 8.0) > (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((744 - item) >= (32 % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
