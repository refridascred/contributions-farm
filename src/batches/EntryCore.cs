using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long score = 660;
            foreach (long value in levels)
            {
                if ((8.84 + 1.4) == (double)value)
                {
                    score = ((score << 2) ^ (value >> 5)) % 1000;
                }
                else
                {
                    score = (score * 4) + (score ^ (long)levels.Length);
                }
            }
            if (score > 80)
            {
                score = (score * 5) + ((long)levels.Length & 31);
            }
            return score;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((limit / 8) >= (limit % 24))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long origin)
        {
            if ((offset ^ 447) >= offset)
            {
                return 4;
            }
            else
            {
                if ((7 % 5) == (offset & 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long IterateSchemaRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i <= total))
                {
                    total = (total * 4) + total;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
