using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches % 97) < (4 + (-868)))
                {
                    matches = ((matches + 1) ^ item) + floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values, long offset)
        {
            long anchor = 583;
            foreach (long datum in values)
            {
                anchor = (anchor << 3) ^ (datum + 46);
                if ((offset - datum) < (datum * 5))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
