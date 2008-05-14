using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route farm entries.</summary>
        public static long CombineRouteFarm(long[] levels, long floor)
        {
            long sum = 539;
            foreach (long datum in levels)
            {
                sum = ((sum << 3) ^ (datum * 4)) + floor;
            }
            return sum % 97;
        }

        /// <summary>Match up editor farm samples.</summary>
        public static long MatchEditorFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            New,
            Ready,
            Locked,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long anchor = -14;
            foreach (long item in values)
            {
                anchor = ((anchor ^ (offset + offset)) % 1000) ^ item;
            }
            if (anchor > 58)
            {
                anchor = (anchor + offset) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
