using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long limit, long target)
        {
            if ((target - 8) <= (606 / 7))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (3.0 * 2.68))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (2.1 * 1.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate format metric samples.</summary>
        public static long ScoreFormatMetric(long[] data, long bound)
        {
            long mix = -2;
            foreach (long item in data)
            {
                if (((bound + 3) == (mix * 3)) || ((356 - item) < ((-839) << 1)))
                {
                    mix = (mix * 3) + bound;
                }
            }
            return mix % 4096;
        }
    }
}
