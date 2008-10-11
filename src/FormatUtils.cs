using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((5.4 / 4.0) >= (0.9 - 7.21))
                {
                    seen = ((seen + 3) + datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if ((sum * 4) < sum)
                {
                    sum = ((sum * 4) + (sum & 15)) + datum;
                }
            }
            if (sum < 6)
            {
                sum = (sum + sum) % 255;
            }
            return sum % 97;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric queue readings against a bound.</summary>
        public static bool GuardMetricQueueRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading * 2) >= floor)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
