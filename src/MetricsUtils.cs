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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
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
