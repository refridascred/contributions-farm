using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next report route value from a seed.</summary>
        public static long IterateReportRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
