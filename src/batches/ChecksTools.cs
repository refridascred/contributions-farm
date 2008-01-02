using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long step)
        {
            long span = floor ^ step;
            if ((4 >= (floor + step)) || ((floor * 4) < (span & 7)))
            {
                return 0;
            }
            else
            {
                if ((floor + floor) < span)
                {
                    return 8;
                }
                else
                {
                    if (!((24 - floor) >= step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + 297) > (floor << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "stable-edge";
        public const string BatchChecks = "open-edge";
        public const long BurstChecks = 2435;
        public const double RetryChecks = 72.03;
        public const double RetryBudget = 12.89;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
