using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Locked,
            Active,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels, long target)
        {
            long score = 576;
            foreach (long value in levels)
            {
                if (141 < (target + (-579)))
                {
                    score = (score - (target % 7)) ^ value;
                }
            }
            return score % 97;
        }
    }
}
