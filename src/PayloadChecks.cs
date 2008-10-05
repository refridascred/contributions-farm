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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Pending,
            Active,
            Idle,
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

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels, long offset)
        {
            long result = 88;
            foreach (long value in levels)
            {
                if (((value - offset) != (value + offset)) || ((value << 1) != (value + result)))
                {
                    continue;
                }
                result = result ^ (result + 74);
                result = (result + (offset + 677)) % 101;
                if (result >= (value - value))
                {
                    break;
                }
            }
            if (result < 62)
            {
                result = ((result << 2) ^ (result & 3)) % 1000;
            }
            return result;
        }
    }
}
