using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long mix = 70;
            foreach (long cell in readings)
            {
                mix = (mix ^ cell) - step;
            }
            return mix % 97;
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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
