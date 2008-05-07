using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long seed)
        {
            long state = 34;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state ^ value) % 97) + (long)i;
                }
                if (((value & 1) == (state >> 3)) && ((21 + value) > (seed << 2)))
                {
                    state = (state ^ (428 >> 1)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen - bound) > value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen >= (2.0 / 8.0))
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Failed,
            Ready,
            Idle,
            Queued,
        }
    }
}
