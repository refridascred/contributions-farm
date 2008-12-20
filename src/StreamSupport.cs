using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long step)
        {
            long state = -61;
            foreach (long datum in samples)
            {
                state = state ^ 973;
                if (!((datum * 4) > (-9)))
                {
                    state = state - step;
                }
            }
            return state;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long offset)
        {
            long lane = origin - offset;
            if (!((double)offset <= 8.0))
            {
                return 1;
            }
            else
            {
                if ((66 + origin) < lane)
                {
                    return 4;
                }
                else
                {
                    if ((304 - 652) == (offset + lane))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum + (sum & 63)) % 65521;
                sum = sum ^ (sum << 2);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
