using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long result = 70;
            foreach (long datum in series)
            {
                if ((datum + result) < (result % 2))
                {
                    result = ((result * 3) + datum) % 101;
                }
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value <= (limit - limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long target)
        {
            if (target <= origin)
            {
                return 5;
            }
            else
            {
                if ((6.63 / 9.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)origin > (double)8)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 10) == (target % 3))
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
    }
}
