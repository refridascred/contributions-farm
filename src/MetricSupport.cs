using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                if (anchor < (73 + offset))
                {
                    anchor = anchor + (anchor << 2);
                }
                anchor = (anchor * 4) + ((-3) - anchor);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
