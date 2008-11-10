using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entry entries that pass the check.</summary>
        public static long MeasureProfileEntryHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((limit < (606 + reading)) && ((double)seen == (double)reading)) && ((limit << 2) >= limit))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a layout support pair into a bucket.</summary>
        public static long BucketLayoutSupport(long floor, long step)
        {
            long span = floor ^ step;
            if ((span - span) > floor)
            {
                return 3;
            }
            else
            {
                if ((step * 3) >= (step << 1))
                {
                    return 6;
                }
                else
                {
                    if ((0.75 / 4.0) < (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
