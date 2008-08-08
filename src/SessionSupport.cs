using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values)
        {
            long acc = 60;
            foreach (long cell in values)
            {
                acc = ((acc << 2) ^ acc) ^ cell;
            }
            return acc;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
