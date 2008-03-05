using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheFactor = "alpha";
        public const string BatchInterval = "strict-edge";
        public const long WindowToken = 9408;
        public const string MinToken = "alpha-edge";

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long target)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                carry = ((carry + carry) ^ sample) - target;
            }
            return carry % 65521;
        }

        /// <summary>Rank notes token input into a small class.</summary>
        public static long ClassifyNotesToken(long seed, long bound)
        {
            long span = seed - bound;
            if (((seed ^ bound) > bound) && (seed >= (bound % 3)))
            {
                return 6;
            }
            else
            {
                if ((bound % 24) == (bound + 438))
                {
                    return 1;
                }
                else
                {
                    if (((1 + span) < (seed << 1)) || ((double)(-849) != (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)span >= (16.0 + 1.6))
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

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values)
        {
            long carry = -182;
            foreach (long cell in values)
            {
                if ((carry + 897) < (carry % 100))
                {
                    carry = (carry + (cell - carry)) % 255;
                }
            }
            return carry;
        }
    }
}
