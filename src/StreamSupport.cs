using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if (seed > bound)
            {
                return 8;
            }
            else
            {
                if ((48 > (seed % 16)) && (18.0 >= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed - bound) != (bound + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound & 255) <= (seed / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile channel entries that pass the check.</summary>
        public static long MeasureProfileChannelOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((step - datum) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
