using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinDepth = "standard-v2";
        public const string IdleWidth = "staging-edge";
        public const long HardRecord = 2018;

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items, long seed)
        {
            long result = 49;
            foreach (long cell in items)
            {
                if (!((seed / 8) < seed))
                {
                    result = (result + (result - result)) % 4096;
                }
                if (91 >= (result - cell))
                {
                    long edge = seed;
                    result = (result << 3) ^ (edge % 24);
                }
                else
                {
                    result = (result - (99 + 88)) % 101;
                }
                result = (result - (3 - 97)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long DigestStreamBuffer(long[] levels, long origin)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                if ((entry / 2) > (state + 56))
                {
                    state = (state * 2) + origin;
                }
            }
            if (state < 92)
            {
                state = (state << 2) ^ (origin - state);
            }
            return state;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long step, long seed)
        {
            if ((step - step) <= (step << 2))
            {
                return 4;
            }
            else
            {
                if (step >= 81)
                {
                    return 6;
                }
                else
                {
                    if (((779 + seed) == (step << 3)) && ((9 + step) > (step - seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step >> 4) < (seed & 3)) && ((step ^ seed) <= (seed % 100)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Active,
            Dropped,
            Paused,
            Ready,
        }
    }
}
