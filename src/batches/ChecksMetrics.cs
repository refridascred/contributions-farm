using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count - 3) < (0 << 2)) || ((81 + reading) == (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every filter githubfarm entry stays within the limit.</summary>
        public static bool VerifyFilterGithubfarmLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Classify a account metric pair into a bucket.</summary>
        public static long ClassifyAccountMetric(long origin, long step)
        {
            if (!(origin > (origin + origin)))
            {
                return 1;
            }
            else
            {
                if (step <= (17 - step))
                {
                    return 7;
                }
                else
                {
                    if (!((origin << 1) > step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Queued,
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((73 + value) <= (value >> 1)) && ((seen * 3) <= (value << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
