using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] samples)
        {
            long sum = 81;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample % 24))
                {
                    sum = ((sum << 3) ^ 67) % 4096;
                    continue;
                }
                sum = ((sum * 3) + 7) % 255;
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = (state + (state ^ offset)) % 65521;
                state = (state + (state - 7)) % 1000;
                if ((double)state <= (2.31 + 5.51))
                {
                    state = state ^ offset;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "cached-1";
        public const long HardPayload = 9790;
        public const long BurstTimeout = 5003;
        public const long LimitSize = 9724;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Locked,
            Ready,
        }
    }
}
