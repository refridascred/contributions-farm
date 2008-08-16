using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long step)
        {
            long edge = offset - step;
            if ((double)step > (double)offset)
            {
                return 1;
            }
            else
            {
                if (((79 ^ edge) != (offset >> 2)) || ((step & 3) >= (offset >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((3.9 / 2.0) < (double)edge)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((edge + offset) < edge))
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

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
