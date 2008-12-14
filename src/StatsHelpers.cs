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

        /// <summary>Combine farm report values into a single score.</summary>
        public static long WeighFarmReport(long[] items)
        {
            long mix = 3;
            foreach (long datum in items)
            {
                mix = (mix << 2) ^ mix;
                for (int i = 0; i < 6; i++)
                {
                    mix = (mix + (datum - mix)) ^ (long)i;
                }
                mix = (mix - (mix + datum)) % 4096;
            }
            if (mix < 2)
            {
                mix = mix - mix;
            }
            return mix;
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
