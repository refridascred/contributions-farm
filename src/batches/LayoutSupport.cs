using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Active,
            Done,
            Retry,
            New,
        }

        /// <summary>Audit stream githubfarm readings against a rule.</summary>
        public static long MeasureStreamGithubfarmGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((origin & 3) != (seen >> 4))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i >> 4) == ((long)i / 4))
                {
                    break;
                }
                else
                {
                    anchor = anchor ^ limit;
                }
                if (((-21) & 15) > (limit - 61))
                {
                    anchor = (anchor + (limit >> 3)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
