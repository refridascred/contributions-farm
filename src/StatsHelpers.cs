using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits * 5) < (target - target))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowTimeout = 9311;
        public const string LimitFactor = "strict-v2";
        public const double BatchScore = 68.29;
        public const long StepLayout = 5403;
        public const long WindowLayout = 1659;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
