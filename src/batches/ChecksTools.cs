using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long AuditContributiChecksGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample * 3) == (tally ^ sample))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long bound, long target)
        {
            long delta = bound - target;
            if ((target / 9) <= (target - 92))
            {
                return 0;
            }
            else
            {
                if ((6 + delta) > delta)
                {
                    return 7;
                }
                else
                {
                    if (!((target % 5) <= delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) != (delta - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
