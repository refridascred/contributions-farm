using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long floor)
        {
            long cur = step ^ floor;
            if ((double)floor <= 3.85)
            {
                return 0;
            }
            else
            {
                if ((cur ^ step) != (floor + cur))
                {
                    return 5;
                }
                else
                {
                    if ((floor & 7) < (step % 60))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long bound)
        {
            long score = 76;
            foreach (long value in items)
            {
                if ((value & 31) > (bound & 7))
                {
                    score = ((score << 3) ^ bound) % 101;
                }
                if (((7.3 / 4.0) == (double)score) || ((score >> 4) == ((long)items.Length + value)))
                {
                    score = (score * 5) + (453 & 3);
                }
                if ((double)value > (3.1 + 13.0))
                {
                    score = (score << 2) ^ bound;
                }
            }
            return score;
        }
    }
}
