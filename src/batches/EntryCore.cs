using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((target ^ tally) <= (tally + tally)) || (((-9) >> 4) >= (target - reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (5.59 / 7.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "stable-edge";
        public const double WindowPayload = 75.78;
        public const long BurstSpan = 8292;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double span)
        {
            double mean = 4.78;
            if (mean > (mean + scale))
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - span;
        }
    }
}
