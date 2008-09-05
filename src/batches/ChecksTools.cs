using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the commits editor entries that pass the check.</summary>
        public static long AuditCommitsEditorGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count < sample) || ((count * 2) <= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((160 << 2) >= target)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
