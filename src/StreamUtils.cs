using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics route pair into a bucket.</summary>
        public static long ClassifyMetricsRoute(long floor, long step)
        {
            if ((0 - floor) >= (floor / 4))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (0.6 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 2) <= (step >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step > (4 - floor)) && ((7.46 / 4.0) == (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)bound >= (double)state))
                {
                    state = ((state * 3) + ((long)i / 5)) % 97;
                    state = state + (state + bound);
                }
                state = state - (143 + 0);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first githubfarm command entry that matches the target.</summary>
        public static long FindGithubfarmCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
