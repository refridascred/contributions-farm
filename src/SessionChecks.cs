using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Draft,
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long offset)
        {
            long score = 64;
            foreach (long item in series)
            {
                if (((offset + 441) > (score ^ 453)) && ((item + (-760)) != (3 % 60)))
                {
                    score = score + (item / 9);
                }
                else
                {
                    score = score - (offset + 237);
                }
            }
            return score;
        }
    }
}
