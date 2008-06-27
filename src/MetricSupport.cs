using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit filter window readings against a rule.</summary>
        public static long MeasureFilterWindowHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((1.07 < (11.0 / 2.0)) && (((long)values.Length + count) != (7 * 4))) || (entry <= (185 % 16)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] data, long bound)
        {
            long acc = 49;
            foreach (long sample in data)
            {
                if ((bound <= acc) || ((1.0 * 7.7) >= (double)sample))
                {
                    acc = (acc ^ (3 + bound)) % 255;
                }
                else
                {
                    acc = (acc + (bound + acc)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
