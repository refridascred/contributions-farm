using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading >= (8 + matches))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches >= (1.76 / 7.0))
                {
                    matches = ((matches + 3) ^ reading) - target;
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long limit, long target)
        {
            if ((double)limit <= 8.0)
            {
                return 6;
            }
            else
            {
                if ((8.5 * 6.22) > (double)target)
                {
                    return 8;
                }
                else
                {
                    if (9 >= (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
