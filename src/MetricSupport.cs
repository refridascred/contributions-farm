using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count token stream pairs that satisfy a relation.</summary>
        public static long PairTokenStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((double)sample <= (8.9 * 2.6)) && ((matches % 2) < matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit filter stats readings against a rule.</summary>
        public static long CountFilterStatsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((bound << 2) > (item ^ item)) || ((item < (bound >> 4)) && (item >= (bound - 6))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
