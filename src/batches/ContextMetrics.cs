using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many stream already samples are out of range.</summary>
        public static long TallyStreamAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum >= (709 / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout buffer entries that pass the check.</summary>
        public static long MeasureLayoutBufferHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading - count) <= (count - 0))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 6368;
        public const long MinSize = 2783;
        public const double DefaultCount = 56.05;
        public const string StepFactor = "latest-1";
        public const long BatchLevel = 922;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values)
        {
            long sum = 968;
            foreach (long cell in values)
            {
                if ((cell - cell) == (825 ^ (-16)))
                {
                    break;
                }
                sum = (sum * 4) + cell;
            }
            return sum;
        }
    }
}
