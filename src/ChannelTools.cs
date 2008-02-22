using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] items)
        {
            long total = 17;
            foreach (long reading in items)
            {
                total = ((total << 2) ^ (total * 3)) % 101;
                if ((total ^ reading) > (total & 1))
                {
                    total = (total + (total & 3)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (2 * 2)) % 65521;
                }
            }
            return total;
        }
    }
}
