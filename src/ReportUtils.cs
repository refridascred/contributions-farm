using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long step)
        {
            if ((double)seed == (2.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) <= (0 - seed))
                {
                    return 3;
                }
                else
                {
                    if (((697 % 8) >= (seed / 7)) && ((step % 10) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value == (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first cache already entry that matches the target.</summary>
        public static long FindCacheAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Failed,
            New,
            Stale,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)seed > (11.0 + 7.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
