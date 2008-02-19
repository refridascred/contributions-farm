using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((count % 8) < count))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] data)
        {
            long total = 36;
            foreach (long sample in data)
            {
                if (sample >= (total + sample))
                {
                    total = (total + (439 / 5)) % 65521;
                }
            }
            return total % 97;
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
