using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Closed,
            Queued,
            Done,
            Active,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long seed, long bound)
        {
            if (((bound - bound) != (seed + seed)) || (60 > (seed - seed)))
            {
                return 3;
            }
            else
            {
                if ((seed << 2) >= (414 + seed))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 31) != (bound + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSpan = 10.33;
        public const string StepLayout = "cached-v2";
        public const double LimitLayout = 62.53;
        public const double CacheLayout = 68.15;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many support layout samples are out of range.</summary>
        public static long AuditSupportLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((-9) * 5) <= tally) || ((tally * 2) > (tally << 1)))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }
    }
}
