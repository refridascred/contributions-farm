using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin - (long)i) < (long)i)
                {
                    mix = ((mix * 5) + ((long)i + mix)) % 65521;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound <= (981 * 3)) || (((long)i - state) >= bound))
                {
                    state = ((state * 4) + (845 >> 1)) % 4096;
                    state = ((state * 2) + ((long)i ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (94 - bound)) % 65521;
                }
                state = state + state;
                state = ((state << 3) ^ bound) % 65521;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next channel commits value from a seed.</summary>
        public static long DeriveChannelCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
