using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the buffer cluster entries that pass the check.</summary>
        public static long CountBufferClusterMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 6) > hits)
                {
                    hits = ((hits + 1) - value) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long mix = 791;
            foreach (long datum in readings)
            {
                mix = ((mix + step) % 1000) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftSize = 35.43;
        public const long LimitInterval = 6843;
        public const long SoftScore = 4045;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Dropped,
            Idle,
            Paused,
            Queued,
            Locked,
        }
    }
}
