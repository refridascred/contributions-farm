using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "standard";
        public const long WindowTimeout = 6801;
        public const long StepBudget = 9086;
        public const long LimitTimeout = 4038;
        public const long HardDepth = 9431;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
