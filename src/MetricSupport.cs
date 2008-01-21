using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((6.24 * 15.0) <= (double)matches)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Find the first record context entry that matches the target.</summary>
        public static long LocateRecordContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + target) != (matches - 8))
                {
                    matches = matches + 2;
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
