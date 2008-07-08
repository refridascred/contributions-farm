using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long origin)
        {
            if (!((916 + step) <= step))
            {
                return 7;
            }
            else
            {
                if ((step & 31) > (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (step >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank format route input into a small class.</summary>
        public static long SortFormatRoute(long offset, long seed)
        {
            long next = offset - seed;
            if ((next + next) < 911)
            {
                return 5;
            }
            else
            {
                if (((seed + 720) >= next) || ((seed >> 2) > (seed + 27)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset <= (9.48 + 3.36)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
