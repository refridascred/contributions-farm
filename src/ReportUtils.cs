using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many buffer format samples are out of range.</summary>
        public static long TallyBufferFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum + seen) <= (datum / 5)) && !((seen & 1) == (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples)
        {
            long score = 90;
            foreach (long entry in samples)
            {
                if ((3.0 - 20.0) == (double)entry)
                {
                    score = ((score << 3) ^ (score % 3)) % 4096;
                }
                score = score ^ (score & 127);
                if ((entry & 15) < score)
                {
                    score = ((score * 2) + (entry * 4)) % 97;
                }
            }
            if (score > 24)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((bound << 2) <= (38 * 2))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((17.0 / 6.0) <= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
