using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long offset, long bound)
        {
            long prev = offset + bound;
            if ((bound << 3) > (bound / 8))
            {
                return 7;
            }
            else
            {
                if ((double)prev >= 9.76)
                {
                    return 2;
                }
                else
                {
                    if ((bound * 2) >= (prev << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound >= 138)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the format buffer series from a seed.</summary>
        public static long StepFormatBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin & 15) != (long)i)
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state - state) % 97;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
