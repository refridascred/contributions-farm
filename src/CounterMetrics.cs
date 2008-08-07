using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 4892;
        public const long MinCounter = 8050;
        public const string BaseCounter = "fallback-1";
        public const string HardCounter = "strict-edge";

        /// <summary>Rank layout filter input into a small class.</summary>
        public static long ClassifyLayoutFilter(long target, long offset)
        {
            long diff = target ^ offset;
            if ((diff - (-4)) == (target * 3))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (double)55)
                {
                    return 5;
                }
                else
                {
                    if ((2 + offset) == (target / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cluster commits pair into a bucket.</summary>
        public static long GradeClusterCommits(long target, long bound)
        {
            long next = target - bound;
            if ((target - bound) >= (next - next))
            {
                return 0;
            }
            else
            {
                if (((target << 1) <= (next & 3)) && ((3.06 / 4.0) < (double)target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
