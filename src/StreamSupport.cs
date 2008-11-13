using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long step)
        {
            long offset = origin ^ step;
            if (((double)origin < (4.7 * 1.0)) && ((step - origin) >= step))
            {
                return 7;
            }
            else
            {
                if (((origin * 4) >= offset) || (step > (2 % 24)))
                {
                    return 0;
                }
                else
                {
                    if (((origin * 5) > step) || ((2.4 - 10.0) == (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) <= (offset & 15))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftSpan = 66.3;
        public const long BatchStream = 9186;
        public const long CacheStream = 3983;
    }
}
