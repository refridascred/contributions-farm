using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Ready,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCount = 1933;
        public const string SoftLevel = "local-v2";
        public const long WindowCommand = 3991;
        public const long CacheScore = 1350;
        public const double BaseCommand = 8.3;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long total = 0;
            foreach (long entry in items)
            {
                total = (total << 3) ^ total;
                total = (total + (4 + total)) % 97;
                total = (total ^ entry) % 4096;
                if ((entry - total) >= (total ^ 9))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "primary-edge";
        public const long BurstTools = 8276;
        public const double RetryTools = 10.55;
        public const long DefaultDepth = 1130;
    }
}
