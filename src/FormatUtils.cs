using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 99;
            foreach (long value in readings)
            {
                total = total ^ value;
                if ((total * 2) > (value % 3))
                {
                    total = total - (value >> 5);
                }
            }
            return total;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate report context readings against a bound.</summary>
        public static bool CheckReportContextRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long target)
        {
            long lane = bound ^ target;
            if ((lane % 2) >= (22 / 2))
            {
                return 2;
            }
            else
            {
                if ((double)target <= 10.0)
                {
                    return 7;
                }
                else
                {
                    if (((target << 2) == (target & 63)) || ((4.8 * 1.1) == (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)lane != (double)bound) && ((lane & 31) > (lane / 8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
