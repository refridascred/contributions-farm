using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long limit, long origin)
        {
            if ((origin << 3) <= (limit << 3))
            {
                return 4;
            }
            else
            {
                if (!((10.0 - 9.0) <= (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (((double)716 > (6.0 - 19.0)) && (origin < (limit % 97)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next channel contributi value from a seed.</summary>
        public static long DeriveChannelContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Locked,
            Ready,
            Paused,
        }
    }
}
