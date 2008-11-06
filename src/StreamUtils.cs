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

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchChannel = "staging-edge";
        public const long CacheCount = 3293;
        public const long IdleChannel = 6160;
        public const string RetryChannel = "legacy-1";
        public const double WindowDepth = 20.02;

        /// <summary>Measure how many schema channel samples are out of range.</summary>
        public static long MeasureSchemaChannelHits(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((1.6 <= (double)(long)values.Length) && ((step & 7) < (67 % 97))))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 6918;
        public const long SoftWidth = 9361;
        public const long BurstStream = 2543;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Digest a series of payload metric entries.</summary>
        public static long FoldPayloadMetric(long[] levels, long offset)
        {
            long carry = 59;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((((carry * 3) + (reading >> 1)) % 4096) + (long)i) + offset;
                }
                if ((15.0 * 14.0) <= (double)reading)
                {
                    carry = ((carry * 2) + (carry * 5)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ reading;
                }
            }
            return carry;
        }
    }
}
