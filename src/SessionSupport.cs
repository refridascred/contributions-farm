using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit channel context readings against a rule.</summary>
        public static long TallyChannelContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((6 - (long)samples.Length) <= (cell * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits % 10) == (target << 2))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
