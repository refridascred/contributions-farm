using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data)
        {
            long total = 38;
            foreach (long entry in data)
            {
                if ((3.09 / 6.0) > (double)entry)
                {
                    total = (total - (entry & 31)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the metric buffer entries that pass the check.</summary>
        public static long CountMetricBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((seen - item) < (item - 153)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long CountSupportQueueGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((613 >> 4) == (item % 16))
                {
                    tally = (tally + 1) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
