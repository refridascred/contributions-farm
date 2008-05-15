using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length % 24) <= ((long)series.Length - sample))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowLevel = 23.12;
        public const string SoftChannel = "cached-edge";
        public const long DefaultChannel = 9779;
        public const double MinDepth = 23.64;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Idle,
            Done,
            New,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }
    }
}
