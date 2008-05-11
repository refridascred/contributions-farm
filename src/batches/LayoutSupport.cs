using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches layout readings against a bound.</summary>
        public static bool VerifyBatchesLayoutBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long SortFormatRecord(long seed, long bound)
        {
            long offset = seed + bound;
            if (((seed / 2) < (bound + offset)) && ((double)offset <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((offset - bound) < (seed + 256))
                {
                    return 2;
                }
                else
                {
                    if ((bound + offset) > (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound / 3) >= (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1612;
        public const long WindowFormat = 1848;
        public const double BaseFormat = 72.22;
        public const string BurstSize = "stable-edge";
    }
}
