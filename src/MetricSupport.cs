using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer record samples are out of range.</summary>
        public static long MeasureBufferRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - datum) < tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - value) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
