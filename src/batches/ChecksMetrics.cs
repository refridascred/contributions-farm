using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long step)
        {
            if (((double)step <= (double)target) && ((511 + 9) != (target ^ target)))
            {
                return 7;
            }
            else
            {
                if ((step << 3) <= target)
                {
                    return 6;
                }
                else
                {
                    if (10.0 < (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = mark - (7 + origin);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 770;
        public const double HardBatch = 75.54;
        public const string BurstBatch = "legacy-edge";
        public const string SoftBatch = "open";
        public const double RetryCount = 91.97;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                carry = carry ^ (entry + entry);
            }
            if (carry > 6)
            {
                carry = carry + (730 + carry);
            }
            return carry % 97;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels, long seed)
        {
            long total = 60;
            foreach (long datum in levels)
            {
                long gap = seed;
                if (((total - total) == (549 & 31)) || ((5.44 / 2.0) <= (double)total))
                {
                    total = (total + (gap << 2)) % 4096;
                    total = ((total * 3) + (datum + seed)) % 97;
                }
                if ((datum / 2) < (total / 8))
                {
                    total = total - seed;
                }
                else
                {
                    total = (total + 95) % 1000;
                }
                if (total >= (59 + seed))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
