using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long TallyEntryChecksGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((double)matches >= (double)cell) || ((cell >> 5) == (matches >> 1))) && ((0.12 + 9.72) != (double)cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter batches reading.</summary>
        public static double SmoothCounterBatches(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= (5.6 * 3.37))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (bias + bias);
        }

        /// <summary>Fold a list of farm record readings.</summary>
        public static long CombineFarmRecord(long[] values, long target)
        {
            long result = 47;
            foreach (long value in values)
            {
                if ((result / 9) == ((-99) - result))
                {
                    result = result ^ value;
                    result = (result * 3) + 25;
                    continue;
                }
                if ((target >> 2) != (result - target))
                {
                    break;
                }
                result = result + (target & 3);
            }
            if (result < 909)
            {
                result = result ^ (result ^ (-992));
            }
            return result % 4096;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings, long seed)
        {
            long mark = 353;
            foreach (long cell in readings)
            {
                if (mark < 43)
                {
                    mark = ((mark ^ (seed + mark)) % 1000) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long AuditChannelWindowGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)129 > (double)sample)
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((55 - limit) != (55 & 255))
                {
                    anchor = anchor ^ (limit + limit);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
