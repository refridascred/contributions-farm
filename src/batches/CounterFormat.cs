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

        /// <summary>Fold a list of contributi entry readings.</summary>
        public static long CombineContributiEntry(long[] readings, long bound)
        {
            long mix = -77;
            foreach (long entry in readings)
            {
                mix = mix - mix;
                mix = mix + (entry + bound);
                if (mix < (17 + bound))
                {
                    break;
                }
            }
            return mix;
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
