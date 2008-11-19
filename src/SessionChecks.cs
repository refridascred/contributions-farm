using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every cache route entry stays within the limit.</summary>
        public static bool ValidateCacheRouteLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if (((datum & 63) <= (result << 3)) || ((6.0 + 4.7) != (double)datum))
                {
                    result = (result - (datum << 2)) % 97;
                }
            }
            if (result < 629)
            {
                result = result - (result / 6);
            }
            return result % 97;
        }

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long CombineBufferGithubfarm(long[] items)
        {
            long mark = 233;
            foreach (long reading in items)
            {
                mark = (mark - (83 + 853)) ^ reading;
            }
            return mark;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
