using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((result - bound) == (447 - bound))
                {
                    break;
                }
                result = ((result << 2) ^ (long)i) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Failed,
            Paused,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 8796;
        public const long StepTimeout = 2848;
        public const double BaseTimeout = 75.05;
        public const double LimitInterval = 70.82;

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
