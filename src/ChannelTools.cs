using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the support payload series from a seed.</summary>
        public static long SeriesSupportPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                if (score >= ((long)i & 127))
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            New,
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
