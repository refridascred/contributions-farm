using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
