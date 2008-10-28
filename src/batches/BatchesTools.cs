using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    carry = ((carry << 3) ^ (13 / 4)) - (long)i3;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)seen < (double)(-56))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
