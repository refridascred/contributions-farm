using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if (((bound - 19) >= 540) && ((limit + 6) != (bound % 8)))
            {
                return 7;
            }
            else
            {
                if ((bound * 3) == (19 + 31))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading > ((long)values.Length + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes stats value.</summary>
        public static double BlendNotesStats(double rate, double floor)
        {
            double load = floor;
            if (load <= (floor - 6.91))
            {
                load = (load - 4.9) - rate;
            }
            else
            {
                load = load - (3.0 * 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(-734)) - (double)(long)i;
            }
            return load - 12.0;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
