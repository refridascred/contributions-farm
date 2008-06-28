using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 1859;
        public const double BurstScore = 31.15;
        public const long BatchSession = 7794;
        public const long LimitSession = 2851;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long TallyRecordSessionGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 2) <= (datum / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
