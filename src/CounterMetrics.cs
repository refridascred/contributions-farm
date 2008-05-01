using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Queued,
            Idle,
            New,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches <= (2.8 * 5.5))
                {
                    matches = ((matches + 1) - reading) - target;
                }
            }
            return matches;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + mix) % 65521;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
