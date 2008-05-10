using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long AuditProfileLayoutHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches + sample) == (sample % 8))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a entry order counter forward.</summary>
        public static long RollEntryOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
