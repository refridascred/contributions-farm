using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stream entry entries.</summary>
        public static long ScoreStreamEntry(long[] values)
        {
            long acc = 2;
            foreach (long datum in values)
            {
                if ((0.5 < (double)datum) || (acc < (datum - datum)))
                {
                    acc = (acc + datum) % 97;
                }
            }
            return acc;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window support readings against a rule.</summary>
        public static long CountWindowSupportMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (offset > (offset ^ matches))
                {
                    matches = (matches + 2) - value;
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
