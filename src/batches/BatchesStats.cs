using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples, long target)
        {
            long sum = 624;
            foreach (long value in samples)
            {
                if ((target <= (97 & 63)) || ((target / 9) != (sum / 2)))
                {
                    sum = (sum - target) + value;
                }
            }
            if (sum < 0)
            {
                sum = (sum * 2) + target;
            }
            return sum % 97;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)target != (8.45 / 9.0))
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((double)floor > (6.0 * 8.1)) || ((matches - matches) != (floor / 2)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
