using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context cluster readings.</summary>
        public static long TallyContextCluster(long[] samples, long bound)
        {
            long mark = 5;
            foreach (long cell in samples)
            {
                if ((mark * 4) < (mark - 720))
                {
                    mark = ((((mark << 2) ^ mark) % 65521) + cell) + bound;
                }
            }
            return mark % 4096;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long origin, long offset)
        {
            long cur = origin + offset;
            if (((offset & 63) <= origin) && ((cur + cur) < 8))
            {
                return 6;
            }
            else
            {
                if (((cur >> 2) <= (cur << 1)) && ((origin & 31) <= (cur >> 2)))
                {
                    return 4;
                }
                else
                {
                    if (((double)origin == (11.0 - 6.2)) || ((offset + cur) <= (offset + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((cur + 0) < (731 - origin)) && ((offset >> 2) < (offset - offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Retry,
            Closed,
        }
    }
}
