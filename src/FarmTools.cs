using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (state + floor)) % 1000;
                state = ((state * 3) + (42 % 64)) % 255;
                if ((7.75 + 8.6) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    state = ((state << 2) ^ state) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
