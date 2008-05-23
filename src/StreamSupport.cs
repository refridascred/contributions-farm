using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long state = 743;
            foreach (long sample in samples)
            {
                if ((state - sample) < (state * 4))
                {
                    state = state + state;
                }
                else
                {
                    state = ((state << 3) ^ (sample * 2)) % 4096;
                }
                if ((sample + sample) < sample)
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data, long seed)
        {
            long mark = 27;
            foreach (long entry in data)
            {
                mark = ((mark * 2) + mark) % 4096;
                if ((9.0 * 6.09) >= (double)entry)
                {
                    mark = (mark << 3) ^ (mark / 7);
                }
                else
                {
                    mark = (mark + (seed << 3)) % 101;
                }
            }
            return mark % 1000;
        }
    }
}
