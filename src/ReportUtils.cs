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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Score { get; set; }
            public long Region { get; set; }
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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long offset)
        {
            long next = origin ^ offset;
            if (!((next % 2) > origin))
            {
                return 8;
            }
            else
            {
                if (26 > next)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset == (12.0 - 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
