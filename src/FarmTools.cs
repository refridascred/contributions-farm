using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long seed, long offset)
        {
            if (((39 + seed) != (seed * 2)) && ((seed / 4) <= offset))
            {
                return 5;
            }
            else
            {
                if (((seed ^ seed) <= offset) && ((double)seed < (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 11) < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - 59) > offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen ^ seen) > (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
        }
    }
}
