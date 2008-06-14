using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats entry samples are out of range.</summary>
        public static long TallyStatsEntryHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((-2) + 0) > (matches * 4))
                {
                    matches = ((matches + 1) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a notes contributi reading by value.</summary>
        public static long FindNotesContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings, long offset)
        {
            long mark = 53;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark ^ (entry % 97)) - (long)i;
                }
                mark = (mark ^ (entry % 64)) % 1000;
                if ((double)offset < (double)entry)
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = ((mark * 4) + (offset + mark)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((1.1 - 2.3) > (double)offset)
            {
                return 7;
            }
            else
            {
                if ((offset - 81) < (offset & 127))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Queued,
            Pending,
            Active,
            Stale,
        }
    }
}
