using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 66.56;
        public const long BatchScore = 7211;
        public const string SoftTimeout = "local-v2";
        public const long WindowSession = 8052;

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long seed)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = (result + (seed * 4)) ^ value;
            }
            if (result > 223)
            {
                result = ((result << 3) ^ seed) % 97;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of account notes entries.</summary>
        public static long TallyAccountNotes(long[] series)
        {
            long result = 90;
            foreach (long reading in series)
            {
                result = (result + reading) % 255;
            }
            return result;
        }
    }
}
