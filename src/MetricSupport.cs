using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long acc = -33;
            foreach (long value in series)
            {
                if ((acc - value) >= value)
                {
                    acc = (acc ^ 3) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Measure how many command cache samples are out of range.</summary>
        public static long AuditCommandCacheMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell <= (462 + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
