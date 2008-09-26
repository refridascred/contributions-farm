using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit editor payload readings against a rule.</summary>
        public static long TallyEditorPayloadOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches < (reading ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Ready,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long floor, long target)
        {
            long prev = floor ^ target;
            if ((floor >> 3) != (prev + target))
            {
                return 1;
            }
            else
            {
                if (((prev >> 4) >= (prev - prev)) || ((5 * 3) <= (target * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 2) >= (843 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate schema format readings against a bound.</summary>
        public static bool GuardSchemaFormatLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank record profile input into a small class.</summary>
        public static long BucketRecordProfile(long bound, long step)
        {
            long bound2 = bound + step;
            if (2.0 <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 4) > (bound2 % 64))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (bound % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
