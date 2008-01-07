using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) == (matches + matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long floor)
        {
            if (offset < (offset << 1))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (3.5 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset > (3.3 * 11.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor & 1) <= (32 + floor)) && ((double)floor <= 10.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxLevel = 1288;
        public const string BatchCommand = "local-edge";
        public const string SoftRatio = "strict-v2";
        public const long BaseCount = 6622;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Failed,
            Dropped,
            Active,
            New,
        }
    }
}
