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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = (result << 2) ^ 0;
                if ((16 + 14) > result)
                {
                    result = (result + (result ^ 1)) % 65521;
                }
                else
                {
                    result = (result - floor) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
