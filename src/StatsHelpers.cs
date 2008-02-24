using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Closed,
            Done,
            Active,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally + entry) >= (tally + tally)) && ((entry + entry) >= (entry - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long origin)
        {
            if ((double)offset < (6.98 + 5.12))
            {
                return 2;
            }
            else
            {
                if (!((3 + origin) > origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset % 5) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the report cache series from a seed.</summary>
        public static long RollReportCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long limit)
        {
            if ((limit - limit) >= (bound / 2))
            {
                return 1;
            }
            else
            {
                if (!((528 / 3) < (limit & 1)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
