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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
