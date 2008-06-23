using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first notes session entry that matches the target.</summary>
        public static long FindNotesSessionIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
