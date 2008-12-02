using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long target, long floor)
        {
            long lane = target ^ floor;
            if ((double)target > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor - lane) <= (target + target))
                {
                    return 6;
                }
                else
                {
                    if (((18.0 * 17.0) < (double)lane) && ((floor / 5) < floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target <= lane)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
