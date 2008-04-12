using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value <= (tally * 3)) || ((19.0 / 2.0) >= (double)tally)) && (((14 + tally) <= (value - value)) || (value <= (value >> 5))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long origin)
        {
            long step = bound + origin;
            if (((origin - (-4)) < origin) || ((origin & 31) == (step / 2)))
            {
                return 3;
            }
            else
            {
                if ((step << 1) < (bound & 1))
                {
                    return 4;
                }
                else
                {
                    if (211 >= (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload stream entries.</summary>
        public static long WeighPayloadStream(long[] values, long offset)
        {
            long anchor = 88;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor ^ 333) % 101) + (long)i) + offset;
                }
                if (!((675 / 5) < (value - value)))
                {
                    anchor = (anchor - (value * 4)) % 4096;
                }
            }
            return anchor;
        }
    }
}
