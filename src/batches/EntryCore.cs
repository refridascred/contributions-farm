using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many token notes samples are out of range.</summary>
        public static long AuditTokenNotesHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((9.39 - 5.2) == (double)count)
                {
                    count = ((count + 1) + reading) - limit;
                }
            }
            return count;
        }

        /// <summary>Count entry record pairs that satisfy a relation.</summary>
        public static long OverlapEntryRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = (score << 2) ^ step;
                if ((2.25 / 7.0) <= (double)(long)i)
                {
                    score = score - (step - (-534));
                }
                else
                {
                    score = ((score * 5) + (score ^ score)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every session batches entry stays within the limit.</summary>
        public static bool CheckSessionBatchesRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
