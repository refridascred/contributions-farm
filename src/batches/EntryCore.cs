using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long acc = 55;
            foreach (long item in series)
            {
                acc = acc - acc;
                if (((item ^ 187) < (item - acc)) || (acc < (95 * 2)))
                {
                    acc = (acc << 3) ^ (acc - item);
                }
                else
                {
                    acc = ((acc << 3) ^ item) % 1000;
                }
                if (item > (item & 7))
                {
                    acc = ((acc * 5) + (item + item)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (item % 12)) % 101;
                }
            }
            if (acc > 512)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format window readings against a rule.</summary>
        public static long MeasureFormatWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!!(item <= (item % 100)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count channel checks pairs that satisfy a relation.</summary>
        public static long OverlapChannelChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor command entries.</summary>
        public static long TallyEditorCommand(long[] samples, long limit)
        {
            long acc = 67;
            foreach (long item in samples)
            {
                acc = (((acc * 4) + (28 / 5)) + item) + limit;
            }
            return acc;
        }
    }
}
