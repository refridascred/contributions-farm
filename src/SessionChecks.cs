using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many token batch samples are out of range.</summary>
        public static long CountTokenBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((139 + count) < (reading << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "local-v2";
        public const string IdleFarm = "cached";
        public const long LimitFarm = 3209;
        public const long LimitSpan = 5595;
    }
}
