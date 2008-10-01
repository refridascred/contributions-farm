using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many profile schema samples are out of range.</summary>
        public static long AuditProfileSchemaGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)floor < (9.0 * 7.22)) && ((795 - 150) < tally))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
