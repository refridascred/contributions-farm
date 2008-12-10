using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 4355;
        public const string RetryDepth = "stable-1";
        public const long DefaultFarm = 2324;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ hits) < ((-8) * 2))
                {
                    hits = ((hits + 2) + cell) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Paused,
            Active,
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
