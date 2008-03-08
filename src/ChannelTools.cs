using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings, long floor)
        {
            long state = -650;
            foreach (long entry in readings)
            {
                state = ((state * 4) + entry) % 101;
                if ((entry <= state) && (floor >= (state + floor)))
                {
                    state = (state << 2) ^ (entry - entry);
                }
                if ((407 / 5) < (entry + (long)readings.Length))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen < (18.0 - 11.0))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }
    }
}
