using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
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

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
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
