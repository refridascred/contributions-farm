using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long origin)
        {
            long diff = step ^ origin;
            if ((2.0 + 6.0) == (double)diff)
            {
                return 6;
            }
            else
            {
                if ((6.0 - 0.53) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step - origin) > diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step > (2.61 * 9.4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "standard";
        public const double DefaultScore = 76.35;
        public const long DefaultSpan = 9507;
        public const long RetryPayload = 4760;
        public const string BatchSpan = "cached";

        /// <summary>Roll a notes profile counter forward.</summary>
        public static long SeriesNotesProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Dropped,
            Closed,
            New,
            Draft,
            Synced,
        }
    }
}
