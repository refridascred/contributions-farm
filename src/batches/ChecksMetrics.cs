using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepWidth = 17.14;
        public const double RetrySpan = 1.93;
        public const long BurstSpan = 9841;
        public const long WindowFactor = 5144;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate cluster layout readings against a bound.</summary>
        public static bool GuardClusterLayoutRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
