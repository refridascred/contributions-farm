using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count - item) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long bound, long bound2)
        {
            if ((bound2 ^ bound2) != (bound << 2))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound2 + bound))
                {
                    return 0;
                }
                else
                {
                    if ((44 << 3) < bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (13.0 <= (double)bound2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(hits < (item >> 5)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
