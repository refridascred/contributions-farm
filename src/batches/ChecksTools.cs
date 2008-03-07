using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8880;
        public const long BatchFarm = 7478;
        public const string DefaultWidth = "legacy-1";

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
