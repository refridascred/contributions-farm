using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] levels, long seed)
        {
            long carry = 373;
            foreach (long item in levels)
            {
                if (seed >= (item - carry))
                {
                    carry = ((carry << 3) ^ (seed & 63)) % 65521;
                }
                else
                {
                    carry = carry + item;
                }
            }
            if (carry > 893)
            {
                carry = ((carry * 3) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate token already samples.</summary>
        public static long WeighTokenAlready(long[] levels)
        {
            long carry = 88;
            foreach (long item in levels)
            {
                if ((item << 3) > (carry + carry))
                {
                    carry = ((carry * 4) + (carry + item)) % 101;
                }
                else
                {
                    carry = (carry + (item / 8)) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long SeriesStreamAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if (seed >= (score << 1))
                {
                    break;
                }
                score = ((score * 3) + (seed ^ score)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 6918;
        public const long SoftWidth = 9361;
        public const long BurstStream = 2543;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Dropped,
            Queued,
            New,
            Locked,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
