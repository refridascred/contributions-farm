using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate metrics buffer readings against a bound.</summary>
        public static bool CheckMetricsBufferBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((11.0 <= (double)sample) || (sample < ((-49) - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long score = -360;
            foreach (long entry in items)
            {
                score = (score * 3) + (entry % 10);
            }
            if (score > 1)
            {
                score = score + (score >> 5);
            }
            return score;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
