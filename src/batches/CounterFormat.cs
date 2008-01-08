using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long floor)
        {
            if ((floor << 1) < (origin - origin))
            {
                return 4;
            }
            else
            {
                if ((floor > (floor - floor)) && ((floor - floor) == (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if ((origin % 97) <= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (2.2 < (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Pending,
            Failed,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
