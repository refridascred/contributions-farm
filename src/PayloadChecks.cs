using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long seed)
        {
            long slot = offset - seed;
            if ((offset ^ offset) < (slot - slot))
            {
                return 4;
            }
            else
            {
                if (!((offset >> 4) > seed))
                {
                    return 0;
                }
                else
                {
                    if (((238 >> 2) > (seed + offset)) && ((seed << 2) <= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset >= (seed << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every filter farm entry stays within the limit.</summary>
        public static bool ValidateFilterFarmBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            if ((target & 31) <= target)
            {
                return 8;
            }
            else
            {
                if (7.22 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if (floor < (floor / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= 0.85)
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
