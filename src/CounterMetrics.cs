using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Draft,
            New,
            Active,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((7 / 3) > limit)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry layout entry stays within the limit.</summary>
        public static bool GuardEntryLayoutLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
