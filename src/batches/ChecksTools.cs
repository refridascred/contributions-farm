using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 4261;
        public const string BatchFormat = "fallback-edge";
        public const long DefaultFactor = 1344;
        public const long StepBudget = 9349;

        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long MeasureSchemaBatchesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((11.0 * 6.2) < (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up buffer commits samples.</summary>
        public static long MatchBufferCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Pending,
            Synced,
        }
    }
}
