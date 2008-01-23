using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long TallyOrderAccountGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length / 6) < matches)
                {
                    matches = ((matches + 3) + value) + seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long step, long floor)
        {
            if ((double)3 <= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((double)floor <= (5.98 + 4.5))
                {
                    return 7;
                }
                else
                {
                    if (!(step >= (step << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - count) <= (92 + count))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }
    }
}
