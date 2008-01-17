using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((seed >= (seed & 63)) && (((double)count >= (7.0 + 3.63)) && ((double)seed <= (0.86 * 6.0))))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
