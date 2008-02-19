using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the stats record entries that pass the check.</summary>
        public static long TallyStatsRecordHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((step + cell) > step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels, long target)
        {
            long sum = 11;
            foreach (long value in levels)
            {
                if (!((sum >> 2) <= target))
                {
                    sum = (((sum << 2) ^ (target << 1)) % 1000) ^ value;
                }
                if ((9 - sum) < (sum & 7))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading > (limit - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
