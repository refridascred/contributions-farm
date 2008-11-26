using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Synced,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) >= (tally + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((24 << 3) > matches)
                {
                    matches = ((matches + 2) + value) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
