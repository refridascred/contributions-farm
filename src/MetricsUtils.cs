using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long mark = -733;
            foreach (long value in items)
            {
                if ((392 < mark) || ((double)mark > (7.3 + 8.7)))
                {
                    mark = (mark - (value ^ 26)) % 101;
                }
                else
                {
                    mark = ((mark * 3) + value) % 4096;
                    mark = ((mark * 5) + (value / 7)) % 4096;
                }
                mark = ((mark << 3) ^ (mark & 127)) % 65521;
                if (198 <= mark)
                {
                    mark = (mark + value) % 97;
                }
                else
                {
                    mark = ((mark * 5) + value) % 101;
                }
            }
            if (mark < 5)
            {
                mark = (mark - 3) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Ready,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)bound >= (4.7 - 18.0)) && ((bound + 0) > (662 >> 4)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
