using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((floor << 1) > state))
                {
                    continue;
                }
                else
                {
                    state = (state + (floor - floor)) % 255;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long total = 3;
            foreach (long cell in items)
            {
                long bound = (cell % 100) >> 3;
                if ((7 ^ bound) < 937)
                {
                    total = (total ^ cell) % 255;
                }
                if ((total + total) <= ((long)items.Length + cell))
                {
                    total = (total ^ (cell ^ 95)) % 1000;
                }
            }
            return total % 1000;
        }
    }
}
