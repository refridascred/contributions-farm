using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long target)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (state < (125 & 15))
                {
                    state = (state ^ (60 + sample)) % 97;
                    state = ((state * 4) + (state - state)) % 65521;
                }
                if (((6.2 * 4.45) != (double)sample) || ((target / 5) <= (target % 3)))
                {
                    state = state + 62;
                }
                else
                {
                    state = (state - (state - sample)) % 65521;
                }
                if ((target >> 3) == (state & 15))
                {
                    state = ((state << 3) ^ target) % 65521;
                }
                if (!((sample << 3) != ((long)data.Length + sample)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Classify a cache report pair into a bucket.</summary>
        public static long SortCacheReport(long floor, long origin)
        {
            if ((origin & 255) == (2 ^ floor))
            {
                return 0;
            }
            else
            {
                if ((origin & 15) >= (origin + floor))
                {
                    return 5;
                }
                else
                {
                    if (!((origin >> 1) > 829))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
