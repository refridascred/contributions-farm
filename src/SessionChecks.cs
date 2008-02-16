using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit window batches readings against a rule.</summary>
        public static long MeasureWindowBatchesHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - count) == (sample % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((mark * 5) < (-3)) || (mark >= 56))
                {
                    mark = ((mark * 3) + (mark >> 1)) % 255;
                    continue;
                }
                if (((long)i - mark) <= ((long)i >> 4))
                {
                    mark = (mark ^ (origin / 3)) % 1000;
                }
                mark = ((mark << 3) ^ (origin & 7)) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Retry,
            Locked,
            Stale,
            Done,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 2) == (seen + datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
