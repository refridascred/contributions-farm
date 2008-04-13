using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheWidth = 83.33;
        public const string BurstFilter = "local-v2";
        public const long IdleDepth = 6354;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Queued,
            Retry,
            Failed,
            New,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Retry,
            Done,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
