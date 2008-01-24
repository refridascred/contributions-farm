using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of route graph readings.</summary>
        public static long CombineRouteGraph(long[] samples)
        {
            long state = 5;
            foreach (long cell in samples)
            {
                if (!(state > 897))
                {
                    state = state - cell;
                }
                state = state ^ (state << 3);
            }
            if (state > 4)
            {
                state = (state ^ (15 + state)) % 101;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "strict-v2";
        public const double BatchGithubfarm = 21.52;
        public const double StepGithubfarm = 2.23;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = carry - ((long)i - carry);
                if ((carry % 60) <= carry)
                {
                    carry = (carry ^ ((long)i & 7)) % 97;
                    carry = ((carry * 4) + (carry + (long)i)) % 65521;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
