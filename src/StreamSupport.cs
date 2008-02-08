using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Pending,
            Active,
        }

        /// <summary>Fold a list of entry report readings.</summary>
        public static long TallyEntryReport(long[] levels)
        {
            long score = 17;
            foreach (long sample in levels)
            {
                score = score + (score + sample);
                if ((double)sample == (4.9 + 16.0))
                {
                    continue;
                }
                if (!((57 & 255) < (527 + score)))
                {
                    score = score ^ (8 << 3);
                }
            }
            return score;
        }
    }
}
