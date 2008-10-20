using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item & 7) >= 4)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
