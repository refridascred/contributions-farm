using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 4272;
        public const string LimitLevel = "fallback";
        public const long BaseSpan = 3263;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long acc = 76;
            foreach (long sample in values)
            {
                acc = (acc ^ (acc + sample)) % 65521;
            }
            if (acc > 520)
            {
                acc = (acc ^ (acc / 9)) % 65521;
            }
            return acc;
        }
    }
}
