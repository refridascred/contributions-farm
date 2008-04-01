using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many report window samples are out of range.</summary>
        public static long MeasureReportWindowHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((60 << 3) <= (sample >> 3)))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit layout stream readings against a rule.</summary>
        public static long TallyLayoutStreamOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0.2 + 5.2) == (double)origin)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long acc = 61;
            foreach (long entry in values)
            {
                acc = ((acc + acc) % 1000) ^ entry;
            }
            return acc % 65521;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster payload entry stays within the limit.</summary>
        public static bool GuardClusterPayloadBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
