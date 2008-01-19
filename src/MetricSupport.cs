using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum + tally) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
