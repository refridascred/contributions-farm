using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 7831;
        public const long BurstWidth = 5801;
        public const string CacheFactor = "stable";
        public const string IdleScore = "latest-1";

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data, long limit)
        {
            long anchor = 33;
            foreach (long reading in data)
            {
                if (((-5) - anchor) >= (reading - anchor))
                {
                    anchor = anchor - (58 * 4);
                }
            }
            if (anchor < 63)
            {
                anchor = ((anchor << 2) ^ (limit ^ limit)) % 101;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSize = 50.23;
        public const long BatchSupport = 1863;
        public const long LimitDepth = 5103;
        public const double LimitScore = 5.57;
    }
}
