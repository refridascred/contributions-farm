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

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
