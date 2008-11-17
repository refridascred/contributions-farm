using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((double)matches != (7.6 * 14.0)) && (value >= (value - value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
