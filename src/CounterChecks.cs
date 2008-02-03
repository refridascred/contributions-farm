using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit route editor readings against a rule.</summary>
        public static long CountRouteEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.3 * 15.0) == (double)matches) && (item > (-669)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stats batches values into a single score.</summary>
        public static long WeighStatsBatches(long[] samples, long offset)
        {
            long mix = 941;
            foreach (long item in samples)
            {
                mix = (mix * 3) + (item - offset);
            }
            return mix % 4096;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long SortProfileBuffer(long seed, long limit)
        {
            if (((double)31 < (double)seed) || ((seed ^ 9) <= (seed % 16)))
            {
                return 0;
            }
            else
            {
                if (((53 + seed) <= seed) || ((double)limit < (9.96 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples)
        {
            long total = 8;
            foreach (long item in samples)
            {
                if ((total - item) > item)
                {
                    total = total - total;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a format notes sample.</summary>
        public static long SeekFormatNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
