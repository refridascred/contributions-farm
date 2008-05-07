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

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long seed)
        {
            long score = 80;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ (36 + entry)) - seed;
            }
            if (score > 345)
            {
                score = (score + (score & 3)) % 255;
            }
            return score;
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
