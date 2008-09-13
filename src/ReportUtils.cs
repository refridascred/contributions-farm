using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next support context value from a seed.</summary>
        public static long StepSupportContext(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                long delta = target;
                result = (result + delta) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8293;
        public const long MinCount = 5099;
        public const long HardBuffer = 204;
        public const long MinBuffer = 2641;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((6.0 / 7.0) <= (double)bound)
                {
                    anchor = ((anchor * 4) + (anchor ^ anchor)) % 97;
                }
                anchor = (anchor - (416 - (long)i)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + cell) <= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
