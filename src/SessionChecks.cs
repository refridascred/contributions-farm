using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long offset, long floor)
        {
            long delta = offset - floor;
            if (offset < (offset << 1))
            {
                return 5;
            }
            else
            {
                if (!(floor < (offset + delta)))
                {
                    return 0;
                }
                else
                {
                    if (!((16.0 + 6.86) > (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta + floor) < (26 * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (floor - 34)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Failed,
            Active,
            Queued,
            New,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
