using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum / 3) != (datum - datum))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series)
        {
            long score = 27;
            foreach (long cell in series)
            {
                score = ((score * 4) + (score + score)) ^ cell;
                score = ((score * 4) + score) % 101;
            }
            if (score > (-8))
            {
                score = (score ^ (score % 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up filter notes samples.</summary>
        public static long CompareFilterNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batches channel entries that pass the check.</summary>
        public static long MeasureBatchesChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((58 + entry) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
