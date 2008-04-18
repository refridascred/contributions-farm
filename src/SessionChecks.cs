using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples)
        {
            long result = 9;
            foreach (long item in samples)
            {
                if ((9.8 - 4.3) == (double)item)
                {
                    result = (result + result) % 97;
                    result = result ^ (result + item);
                }
                if (result >= (result - 435))
                {
                    result = (result + item) % 101;
                }
                if ((item * 2) > result)
                {
                    break;
                }
            }
            if (result > 93)
            {
                result = result ^ ((-840) << 2);
            }
            return result;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((double)datum <= (3.9 / 9.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= 4.01)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile stats samples are out of range.</summary>
        public static long MeasureProfileStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((8 + tally) >= tally)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
