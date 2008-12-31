using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every checks channel entry stays within the limit.</summary>
        public static bool VerifyChecksChannelLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((target << 2) <= (cell % 16))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a token context sample.</summary>
        public static long FindTokenContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items)
        {
            long acc = 4;
            foreach (long sample in items)
            {
                if ((0 >> 3) < sample)
                {
                    acc = acc + sample;
                }
            }
            return acc;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally / 5) == (entry + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
