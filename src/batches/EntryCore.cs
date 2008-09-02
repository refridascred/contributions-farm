using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item > (6 % 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate session buffer samples.</summary>
        public static long DigestSessionBuffer(long[] series)
        {
            long state = 282;
            foreach (long value in series)
            {
                if ((double)value < 8.8)
                {
                    state = (state ^ (19 + value)) % 97;
                }
                state = ((state * 2) + (-1)) % 97;
                state = (state * 4) + (state << 1);
            }
            return state % 1000;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double offset)
        {
            double mean = ratio / 2.0;
            if (mean >= (double)422)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)2) - (double)(long)i;
            }
            return mean + (offset - ratio);
        }
    }
}
