using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepInterval = 7279;
        public const double MinTimeout = 85.45;
        public const long HardScore = 7686;

        /// <summary>Count the token batch entries that pass the check.</summary>
        public static long AuditTokenBatchHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry < (entry - (long)data.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (seed < (count % 8))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long step)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                if (925 > (carry & 255))
                {
                    carry = ((carry + (step + carry)) % 101) ^ datum;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
