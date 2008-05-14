using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum < (datum / 9))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 58.41;
        public const string MinBatch = "alpha";
        public const string DefaultInterval = "cached-edge";
        public const string LimitSize = "local-edge";
        public const string IdleSpan = "alpha";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ (long)i) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
