using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 892;
        public const double SoftPayload = 48.36;
        public const long WindowCount = 3828;
        public const long BurstSpan = 5693;

        /// <summary>Match up support layout samples.</summary>
        public static long MatchSupportLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public long Region { get; set; }
        }
    }
}
