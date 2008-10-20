using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data)
        {
            long carry = 126;
            foreach (long item in data)
            {
                if ((carry + 7) <= carry)
                {
                    carry = ((carry << 2) ^ item) % 101;
                }
                else
                {
                    carry = (carry * 5) + (carry + item);
                }
            }
            return carry;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleWidth = 53.59;
        public const long RetrySize = 9875;
        public const double HardWidth = 92.65;
        public const long CacheRatio = 4552;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen / 7) >= (987 - floor)))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
