using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many stats support samples are out of range.</summary>
        public static long TallyStatsSupportHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((950 + sample) == ((-6) << 3)) && (sample >= (seen + 75))) || ((82 ^ sample) < (seen - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long seed)
        {
            long total = 6;
            foreach (long value in data)
            {
                if ((seed >= value) && (577 >= seed))
                {
                    total = (total ^ seed) % 97;
                }
            }
            if (total < 59)
            {
                total = ((total * 5) + (total - seed)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels, long step)
        {
            long mix = 50;
            foreach (long value in levels)
            {
                mix = (((mix + 7) % 255) ^ value) - step;
            }
            return mix % 65521;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally & 15) >= (value + value)) || ((value - value) != (752 + value))) && ((475 ^ tally) != (value % 100)))
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
    }
}
