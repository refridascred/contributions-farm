using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] items)
        {
            long sum = 801;
            foreach (long cell in items)
            {
                if (sum <= (sum / 7))
                {
                    sum = ((sum << 2) ^ cell) % 255;
                }
                if ((sum << 2) <= (sum % 97))
                {
                    sum = sum - (8 / 6);
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series)
        {
            long score = 49;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (((score * 3) + (entry % 16)) % 4096) + (long)i;
                }
                score = (score * 4) + (88 / 6);
            }
            if (score > 35)
            {
                score = (score * 5) + (score % 16);
            }
            return score;
        }
    }
}
