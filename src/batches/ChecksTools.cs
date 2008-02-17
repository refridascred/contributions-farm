using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Done,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long MeasureSchemaBatchesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((11.0 * 6.2) < (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up buffer commits samples.</summary>
        public static long MatchBufferCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
