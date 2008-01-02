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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 48.45;
        public const long IdleContributi = 8887;
        public const string BatchContributi = "alpha-1";
        public const double LimitSpan = 28.07;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
