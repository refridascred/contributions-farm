using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheCount = 2873;
        public const long WindowProfile = 4070;
        public const long StepSize = 7825;
        public const long RetryFactor = 7531;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = ((carry * 4) + (cell % 24)) % 255;
            }
            return carry;
        }
    }
}
