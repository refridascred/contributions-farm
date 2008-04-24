using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long seed)
        {
            long carry = 18;
            foreach (long cell in series)
            {
                carry = ((carry + (cell + 179)) % 97) - seed;
            }
            return carry;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long step, long seed)
        {
            long lane = step ^ seed;
            if (((seed + 42) != (lane << 2)) || ((seed + lane) > seed))
            {
                return 3;
            }
            else
            {
                if ((lane + step) >= (lane - 447))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
