using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the batch entry series from a seed.</summary>
        public static long SeriesBatchEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = carry + (carry + carry);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryDepth = 9036;
        public const double BurstProfile = 22.77;
        public const long SoftSize = 7466;
        public const long RetryProfile = 2818;
        public const string CacheBudget = "alpha-edge";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
