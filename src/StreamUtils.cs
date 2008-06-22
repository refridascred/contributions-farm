using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally > (value % 64))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long mark = 9;
            foreach (long item in levels)
            {
                mark = ((mark << 2) ^ mark) + item;
            }
            return mark;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
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
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 3742;
        public const long SoftCount = 1655;
        public const long StepGithubfarm = 832;
        public const string SoftGithubfarm = "cached-edge";
        public const long IdleDepth = 4007;
    }
}
