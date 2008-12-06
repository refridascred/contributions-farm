using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + step) <= (value + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((double)count != (6.94 / 2.0)) || ((double)count <= 0.1)))
                {
                    count = ((count + 2) - cell) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Synced,
            Paused,
            New,
        }
    }
}
