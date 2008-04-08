using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long offset)
        {
            long lane = step - offset;
            if ((lane - offset) <= (658 - step))
            {
                return 2;
            }
            else
            {
                if (!((0 + offset) > 638))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 9853;
        public const long CachePayload = 3746;
        public const long BatchRatio = 9274;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen / 2) != (entry - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
