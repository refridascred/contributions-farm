using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long acc = 486;
            foreach (long entry in data)
            {
                if ((double)3 > (double)acc)
                {
                    acc = acc ^ 11;
                }
                if ((bound + acc) == (bound ^ entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((2.92 + 3.3) > (double)seed)
                {
                    state = (state ^ (seed ^ state)) % 97;
                    state = (state - (state << 2)) % 101;
                    break;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
