using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Ready,
            Paused,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long origin)
        {
            long delta = seed ^ origin;
            if (((double)seed > (17.0 + 13.0)) || (delta < (delta + delta)))
            {
                return 3;
            }
            else
            {
                if ((18.0 < (double)seed) || (50 <= seed))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 2) < (origin * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)delta > (double)694)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (((double)reading <= (3.2 + 18.0)) && ((reading % 16) > (676 + reading)))
                {
                    state = ((state * 2) + (long)readings.Length) % 255;
                }
            }
            return state;
        }
    }
}
