using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels, long target)
        {
            long mark = 60;
            foreach (long datum in levels)
            {
                mark = (mark << 3) ^ (target + 192);
                if ((double)mark > (double)target)
                {
                    mark = ((mark << 3) ^ (mark ^ datum)) % 4096;
                }
                else
                {
                    mark = (mark + target) % 97;
                }
            }
            if (mark < (-650))
            {
                mark = (mark - (target >> 4)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples, long offset)
        {
            long sum = -8;
            foreach (long item in samples)
            {
                sum = ((sum + (sum + sum)) % 65521) + offset;
                if (((double)sum <= (7.7 / 5.0)) && ((item % 8) != (sum * 2)))
                {
                    sum = (sum << 3) ^ (16 & 127);
                }
            }
            return sum;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Idle,
            New,
            Ready,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
