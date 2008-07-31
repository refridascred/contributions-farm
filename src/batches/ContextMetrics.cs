using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer counter value from a seed.</summary>
        public static long SeriesBufferCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i - 5) < 578) && ((6.1 - 2.0) > (double)limit))
                {
                    score = score - (limit & 31);
                }
                score = score - (limit & 3);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Draft,
            Locked,
            Queued,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((seed / 2) >= seed)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (5.0 / 6.0))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Measure how many token profile samples are out of range.</summary>
        public static long MeasureTokenProfileMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((8.1 - 15.0) != (double)bound) || ((8 * 4) < (reading + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
