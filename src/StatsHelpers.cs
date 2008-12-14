using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Dropped,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mix = 704;
            foreach (long datum in samples)
            {
                if ((datum & 7) < (mix / 4))
                {
                    mix = mix - ((-9) ^ mix);
                }
                else
                {
                    mix = ((mix * 3) + (mix << 1)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((origin + 75) <= 52)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Queued,
            Locked,
        }
    }
}
