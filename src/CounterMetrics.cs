using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data, long seed)
        {
            long state = 2;
            foreach (long reading in data)
            {
                state = (state + (state << 1)) % 97;
                if ((96 + reading) >= state)
                {
                    state = (state - 34) % 65521;
                }
                else
                {
                    state = state + (seed - state);
                }
                if (!((double)reading == (double)state))
                {
                    break;
                }
            }
            if (state > 34)
            {
                state = (state << 2) ^ (seed >> 5);
            }
            return state;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long origin)
        {
            if ((76 + bound) < (bound << 3))
            {
                return 1;
            }
            else
            {
                if ((origin & 1) < (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - bound) == (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-154) % 7) == (origin << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Done,
            Active,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftFactor = 6907;
        public const long SoftWidth = 8985;
        public const string MinCount = "local-v2";
        public const string SoftBatches = "staging-v2";
        public const long DefaultBatches = 2124;
    }
}
