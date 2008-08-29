using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank buffer schema input into a small class.</summary>
        public static long ClassifyBufferSchema(long origin, long step)
        {
            long next = origin + step;
            if ((origin - next) == (step / 3))
            {
                return 2;
            }
            else
            {
                if ((double)next == (12.0 * 18.0))
                {
                    return 4;
                }
                else
                {
                    if (((origin ^ origin) <= (origin ^ step)) && ((origin >> 4) != (92 - next)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin >= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Done,
            Closed,
        }
    }
}
